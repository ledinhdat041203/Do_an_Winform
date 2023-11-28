using BLL;
using DTO;
using GUI;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frm_BanHang : Form
    {
        public KhachHang khachhang = null;
        DonBan donBan = new DonBan();

        public frm_BanHang()
        {
            InitializeComponent();
        }

        public frm_BanHang(DonBan donBan)
        {
            InitializeComponent();
            this.donBan = donBan;
            this.khachhang = KhachHangBLL.Instance.FindByID(donBan.MaKH);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            frmQuanLiKhachHang frmQuanLiKH = new frmQuanLiKhachHang();
            // kiểm tra đơn đã được tạo chưa nến khach hang = null => đơn chưa được tao
            if (khachhang == null)
            {
                frmQuanLiKH.mydata = new frmQuanLiKhachHang.GETDATA(GetValue);
                frmQuanLiKH.ShowDialog();
                if (khachhang != null)
                {
                    //lấy thông tin nhân viên tạo đơn từ formQuanLi
                    frm_QuanLy frmQL = Application.OpenForms.OfType<frm_QuanLy>().FirstOrDefault();
                    NhanVien nhanVienTaoDon = frmQL.nhanVien;
                    donBan.MaNV = nhanVienTaoDon.MaNV;

                    //them  đon bán vào database
                    try
                    {
                        if (DonBanBLL.Instance.Insert(donBan.MaNV, khachhang.MaKH))
                        {
                            lbTenKH.Text = $"Khách hàng: {khachhang.TenKH}";
                            donBan.MaKH = khachhang.MaKH;
                            donBan.MaDon = DonBanBLL.Instance.GetMaDon();
                            flpChiTietDonBan.Controls.Clear();
                        }
                        LoadDon();
                    }
                    catch (SqlException ex)
                    {
                        foreach (SqlError error in ex.Errors)
                        {
                            if (error.Message.Contains("Nhan vien ki thuat"))
                            {
                                MessageBox.Show("Nhân viên kĩ thuật không được tạo đơn bán", "Thông báo");
                            }
                        }
                    }
                }
            }
            // nếu đơn đã được tạo => người dùng đang muốn đổi khách hang của đơn đó
            else
            {
                frmQuanLiKH.mydata = new frmQuanLiKhachHang.GETDATA(GetValue);
                frmQuanLiKH.ShowDialog();
                if (khachhang != null)
                {
                    //update khach hang cua don
                    if (DonBanBLL.Instance.UpdateKH(donBan.MaDon, khachhang.MaKH))
                    {
                        MessageBox.Show("Đổi tên người mua thành công", "Thông báo");
                        lbTenKH.Text = $"Khách hàng: {khachhang.TenKH}";
                        donBan.MaKH = khachhang.MaKH;
                        LoadDon();
                    }
                }
            }
        
        }

        private void LoadAllHang()
        {
            flpHang.Controls.Clear();
            List<Hang> list = HangBLL.Instance.LayDuLieuBLL();
            foreach (Hang hang in list)
            {
                uc_item item = new uc_item(hang, isSale: true);
                //item.Tag = hang;
                item.ButtonAddClick += ucItem_ClickAdd;

                flpHang.Controls.Add(item);
            }
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            cbVoucher.SelectedIndexChanged -= cbVoucher_SelectedIndexChanged;
            cbLoai.SelectedIndexChanged -= cbLoai_SelectedIndexChanged;

            LoadAllHang();

            cbVoucher.DisplayMember = "TenVoucher";
            cbVoucher.ValueMember = "MaVoucher";
            DataTable dataTable = VoucherBLL.Instance.FindAll(DateTime.Now);
            cbVoucher.DataSource = dataTable.DefaultView;
            cbVoucher.SelectedIndex = -1;

            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "MaLoai";
            dataTable = LoaiHangBLL.Instance.findAllLoai();
            cbLoai.DataSource = dataTable.DefaultView;
            cbLoai.SelectedIndex = -1;
            cbLoai.Text = "Danh mục sản phẩm";

            if (donBan.MaDon != 0)
            {
                lbTenKH.Text = $"Khách hàng: {khachhang.TenKH}";
                LoadDon();
                
                cbVoucher.SelectedIndex = donBan.MaVoucher-1;
                //load các chi tiết đơn đã có lên
                List<ChiTietDonHang> lst = ChiTietDonBanBLL.Instance.FindByMaDon(donBan.MaDon);
                foreach (ChiTietDonHang ct in lst)
                {
                    uc_itemSummary ucCT = new uc_itemSummary(ct, isSale: true);
                    ucCT.SoLuongChanged += ucCTDon_SoLuongChanged;
                    flpChiTietDonBan.Controls.Add(ucCT);
                }

            }
            cbLoai.SelectedIndexChanged += cbLoai_SelectedIndexChanged;
            cbVoucher.SelectedIndexChanged += cbVoucher_SelectedIndexChanged;
        }

        private void ucItem_ClickAdd(object sender, EventArgs e)
        {
            if (donBan != null && donBan.MaDon != 0) // có đơn bán thì mới có thể click vào các uc_hang
            {
                // gán sender bằng ucHang mà bạn đã nhấp vào
                uc_item clickedItem = sender as uc_item;
                ChiTietDonHang ctDonBan = new ChiTietDonHang();
                ctDonBan.MaHang = clickedItem.hang.MaHang;
                ctDonBan.MaDon = this.donBan.MaDon;
                ctDonBan.SoLuong = 1;
                ctDonBan.ThanhTien = clickedItem.hang.DonGia;
                try
                {
                    if (ChiTietDonBanBLL.Instance.Insert(ctDonBan))
                    {
                        LoadDon();
                        ctDonBan.MaChiTiet = ChiTietDonBanBLL.Instance.GetMaCT();
                        uc_itemSummary ucCTDonBan = new uc_itemSummary(ctDonBan, isSale: true);
                        ucCTDonBan.SoLuongChanged += ucCTDon_SoLuongChanged;
                        flpChiTietDonBan.Controls.Add(ucCTDonBan);
                    }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        if (error.Message.Contains("Khong co du hang"))
                        {
                            MessageBox.Show("Mặt hàng này hiện đã hết", "Thông báo");
                        }
                        else if (error.Message.Contains("da thanh toan"))
                        {
                            MessageBox.Show("Đơn hàng này đã được thanh toán !!", "Thông báo");
                        }
                    }
                }
            }
        }

        private void ucCTDon_SoLuongChanged(object sender, EventArgs e)
        {
            LoadDon();
        }

        private void LoadDon()
        {
            donBan = DonBanBLL.Instance.GetDonBanById(donBan.MaDon);
            lbTongGT.Text = $"{donBan.TongGT.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
            //lbChietKhau.Text = $"Chiết khấu: {donBan.ChieuKhau}";
            lbThanhTien.Text = $"{donBan.ThanhTien.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
            //lbVAT.Text = $"VAT: {donBan.VAT}";
        }

        public void GetValue(KhachHang kh)
        {
            this.khachhang = kh;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            findListHang();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (donBan != null && donBan.MaDon != 0 && cbVoucher.SelectedIndex != -1)
            {
                int maVoucher = int.Parse(cbVoucher.SelectedValue.ToString());
                try
                {
                    if (DonBanBLL.Instance.UpdateVoucher(maVoucher, donBan.MaDon))
                    {
                        donBan.MaVoucher = maVoucher;
                        MessageBox.Show("Đã đổi voucher", "thông báo");
                        LoadDon();
                    }
                } catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        if (error.Message.Contains("Khong su dung duoc voucher nay"))
                        {
                            MessageBox.Show("Voucher đã hết hạn sử dụng", "thông báo");
                            cbVoucher.SelectedIndex = -1;
                        }
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (donBan.TrangThai == "Đã thanh toán")
            {
                MessageBox.Show("Không thể thanh toán đơn hàng đã thanh toán !!", "Thông Báo");
                
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xác nhận thanh toán đơn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {


                    try
                    {
                        if (DonBanBLL.Instance.ThanhToanDon(donBan.MaDon))
                        {
                            MessageBox.Show("Đã thanh toán đơn", "Thông báo");
                            donBan.TrangThai = "Đã thanh toán";

                            flpChiTietDonBan.Controls.Clear();
                            this.donBan = new DonBan();
                            this.khachhang = null;
                            lbTenKH.Text = "Khách hàng";
                            lbTongGT.Text = "0 đ";
                            lbThanhTien.Text = "0 đ";
                            cbVoucher.SelectedIndexChanged -= cbVoucher_SelectedIndexChanged;
                            cbVoucher.SelectedIndex = -1;
                            cbVoucher.SelectedIndexChanged += cbVoucher_SelectedIndexChanged;
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Thanh toán thất bại", "Thông báo");
                    }
                }
            }
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            findListHang();
        }

        private void findListHang()
        {
            string loai = cbLoai.Text;
            string tenhang = txtTenHang.Text;
            flpHang.Controls.Clear();
            List<Hang> list = HangBLL.Instance.findListHang(tenhang, "", loai, "");
            foreach (Hang hang in list)
            {
                uc_item item = new uc_item(hang, isSale: true);
                item.Tag = hang;
                item.ButtonAddClick += ucItem_ClickAdd;

                flpHang.Controls.Add(item);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu đon hàng", "Thông báo");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAllHang();  
        }
    }
}
