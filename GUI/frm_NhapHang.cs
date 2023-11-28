using BLL;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_NhapHang : Form
    {
        public DonNhap donNhap = new DonNhap();

        public frm_NhapHang()
        {
            InitializeComponent();
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
           LoadAllHang();
        }

        private void LoadAllHang()
        {
            flpHang.Controls.Clear();
            List<Hang> list = HangBLL.Instance.LayDuLieuBLL();
            foreach (Hang hang in list)
            {
                uc_itemNhapHang item = new uc_itemNhapHang(hang);
                item.ButtonAddClick += btnAddClick;
                item.Tag = hang;
                flpHang.Controls.Add(item);
            }
        }
        private void flpHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_NhapHang_Load(object sender, EventArgs e)
        {
            cbLoai.SelectedIndexChanged -= cbLoai_SelectedIndexChanged;
            pnDonNhap.Visible = false;
            LoadAllHang();
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "MaLoai";
            DataTable dataTable = LoaiHangBLL.Instance.findAllLoai();
            cbLoai.DataSource = dataTable.DefaultView;
            cbLoai.SelectedIndex = -1;
            cbLoai.Text = "Danh mục sản phẩm";

            cbLoai.SelectedIndexChanged += cbLoai_SelectedIndexChanged;

        }

        private void btnAddClick(object sender, EventArgs e)
        {
            if (donNhap != null && donNhap.MaDon != 0)
            {
                // gán sender bằng ucHang mà bạn đã nhấp vào
                uc_itemNhapHang clickedItem = sender as uc_itemNhapHang;
                ChiTietDonHang ctDonNhap = new ChiTietDonHang();
                ctDonNhap.MaHang = clickedItem.hang.MaHang;
                ctDonNhap.MaDon = this.donNhap.MaDon;
                ctDonNhap.SoLuong = 1;
                ctDonNhap.ThanhTien = clickedItem.hang.GiaNhap;
                if (ChiTietDonNhapBLL.Instance.Insert(ctDonNhap))
                {
                    LoadDon();
                    ctDonNhap.MaChiTiet = ChiTietDonNhapBLL.Instance.GetMaCT();
                    uc_itemSummary ucCTDonBan = new uc_itemSummary(ctDonNhap, isSale: false);
                    ucCTDonBan.SoLuongDonNhapChanged += ucCTDon_SoLuongChanged;
                    flpChiTietDon.Controls.Add(ucCTDonBan);
                }
            }
        }

        private void ucCTDon_SoLuongChanged(object sender, EventArgs e)
        {
            LoadDon();
        }

        private void LoadDon()
        {
            donNhap.TongGT = DonNhapBLL.Instance.GetTongGTById(donNhap.MaDon);
            lbTongGT.Text = $"{donNhap.TongGT.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
        }

        private void btnThemDon_Click(object sender, EventArgs e)
        {
            pnDonNhap.Visible = true;
            //lấy thông tin nhân viên từ form cha (form quản lí)
            frm_QuanLy frmQL = Application.OpenForms.OfType<frm_QuanLy>().FirstOrDefault();
            NhanVien nhanVienTaoDon = frmQL.nhanVien;
            if (DonNhapBLL.Instance.Insert(nhanVienTaoDon.MaNV))
            {
                donNhap.MaDon = DonNhapBLL.Instance.GetMaDon();
                flpChiTietDon.Controls.Clear();
            }
        }

        private void lbTongGT_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (DonNhapBLL.Instance.UpdateThanhToan(donNhap.MaDon))
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo");
                    flpChiTietDon.Controls.Clear();
                    this.donNhap = new DonNhap();
                    lbTongGT.Text = "0";
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemhang_Click(object sender, EventArgs e)
        {
            frm_ThemSanPhamMoi fThemSp = new frm_ThemSanPhamMoi();
            fThemSp.ThemSanPham += LoadNewSP;
            fThemSp.ShowDialog();
        }

        private void LoadNewSP(object sender, EventArgs e)
        {
            LoadAllHang();
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maLoai = int.Parse(cbLoai.SelectedValue.ToString());
            flpHang.Controls.Clear();
            List<Hang> list = HangBLL.Instance.FindByMaLoai(maLoai);
            foreach (Hang hang in list)
            {
                uc_itemNhapHang item = new uc_itemNhapHang(hang);
                item.ButtonAddClick += btnAddClick;
                item.Tag = hang;
                flpHang.Controls.Add(item);

                flpHang.Controls.Add(item);
            }
        }
    }
}
