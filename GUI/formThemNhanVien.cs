using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formThemNhanVien : Form
    {
        NhanVien nhanvien = null;
        bool isUpdate = false;
        public formThemNhanVien()
        {
            InitializeComponent();
        }

        public formThemNhanVien(NhanVien nv, bool isUpdate = false)
        {
            InitializeComponent();
            this.nhanvien = nv;
            this.isUpdate = isUpdate;
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            NhanVien newNhanVien = new NhanVien();
            
            newNhanVien.TenNV = txtTenNV.Text;
            newNhanVien.NgaySinh = dtNgaySinh.Value.ToString("yyyy/MM/dd");
            newNhanVien.GioiTinh = cbGioiTinh.Text;
            newNhanVien.SDT = txtSDT.Text;
            newNhanVien.DiaChi = txtDiaChi.Text;
            newNhanVien.ChucVu = cbChucVu.Text;
            newNhanVien.Anh = Utils.Instance.ImageLocationToByteArray(pbAnh.ImageLocation);
            if (newNhanVien.Anh == null)
            {
                newNhanVien.Anh = Utils.Instance.ImageToByteArray(Properties.Resources.avt61);
            }    
            try
            {
                if (!isUpdate)
                {
                    if (NhanVienBLL.Instance.ThemNhanVien(newNhanVien) )
                    {
                        txtTenNV.Focus();
                        TaiKhoanNV tk = new TaiKhoanNV();
                        tk.manv = TaiKhoanNVBLL.Instance.GetMaNV();
                        tk.matkhau = txtMatKhau.Text;
                        tk.taikhoan = txtTenDangNhap.Text;

                        try
                        {
                            if (TaiKhoanNVBLL.Instance.Insert(tk))
                            {
                                MessageBox.Show("Thêm nhân viên thành công", "Thông báo");

                                this.Close();
                            }

                        }
                        catch (SqlException ex)
                        {
                            foreach (SqlError error in ex.Errors)
                                if (error.Message.Contains("Mat Khau"))
                                {
                                    MessageBox.Show("Mật khẩu phải có tối thiểu 8 kí tự và 1 kí tự đăc biệt", "Lỗi");
                                    txtMatKhau.Focus();
                                }
                                else if (error.Message.Contains("UQ_TaiKhoan"))
                                {
                                    MessageBox.Show("Tạo tài khoản thất bại do tên đăng nhập đã tồn tại", "Lỗi");
                                    txtTenDangNhap.Focus();
                                }

                                else
                                    MessageBox.Show(error.Message, "lỗi");
                                NhanVienBLL.Instance.XoaNhanVien(tk.manv);
                        }
                        this.Close();
                    }
                }
                else
                {
                    TaiKhoanNV tk = new TaiKhoanNV();
                    tk.manv = nhanvien.MaNV;
                    tk.taikhoan = txtTenDangNhap.Text;
                    tk.matkhau = txtMatKhau.Text;

                    newNhanVien.MaNV = nhanvien.MaNV;
                    if (NhanVienBLL.Instance.SuaThongTin(newNhanVien) && TaiKhoanNVBLL.Instance.Update(tk))
                    {
                        MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin Thất bại!!", "Thông báo");
                    }
                }

            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    if (error.Message.Contains("ck_lenSTD_NV"))
                    {
                        MessageBox.Show("Số điện thoại không tồn tại", "Lỗi");
                        txtSDT.Focus();
                    }
                    else if (error.Message.Contains("ck_NgaySinhNV"))
                    {
                        MessageBox.Show("nhân viên chưa đủ tuổi lao động", "lỗi");
                        dtNgaySinh.Focus();
                    }
                    else if (error.Message.Contains("SDTNhanVien"))
                    {
                        MessageBox.Show("Số điện thoại đã được đăng kí", "lỗi");
                        txtSDT.Focus();
                    }
                    else if (error.Message.Contains("Mat Khau"))
                    {
                        MessageBox.Show("Mật khẩu phải có tối thiểu 8 kí tự và 1 kí tự đăc biệt", "Lỗi");
                        txtMatKhau.Focus();
                    }
                    else if (error.Message.Contains("UQ_TaiKhoan"))
                    {
                        MessageBox.Show("Tạo tài khoản thất bại do tên đăng nhập đã tồn tại", "Lỗi");
                        txtTenDangNhap.Focus();
                    }
                    else
                        MessageBox.Show($"Error Number: {error.Number}, Message: {error.Message}", "error");
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (img.ShowDialog() == DialogResult.OK)
            {
                pbAnh.ImageLocation = img.FileName;
            }
        }

        private void formThemNhanVien_Load(object sender, EventArgs e)
        {
            pbAnh.Image = Properties.Resources.avt61;
            if (nhanvien != null)
            {
                txtDiaChi.Text = nhanvien.DiaChi;
                txtTenNV.Text = nhanvien.TenNV;
                txtSDT.Text = nhanvien.SDT;
                dtNgaySinh.Value = DateTime.ParseExact(nhanvien.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cbChucVu.Text = nhanvien.ChucVu;
                cbGioiTinh.Text = nhanvien.GioiTinh;
                pbAnh.Image = Utils.Instance.converByteToImage(nhanvien.Anh);

                TaiKhoanNV tk = TaiKhoanNVBLL.Instance.FindByMaNV(nhanvien.MaNV);
                txtTenDangNhap.Text = tk.taikhoan;
                txtMatKhau.Text = tk.matkhau;

                if (!isUpdate)
                {
                    txtDiaChi.ReadOnly = true;
                    txtTenNV.ReadOnly = true;
                    txtSDT.ReadOnly = true;
                    cbChucVu.Visible = false;
                    cbGioiTinh.Visible = false;

                    lbChucVu.Text = nhanvien.ChucVu;
                    lbChucVu.Visible = true;

                    lbGioiTinh.Text = nhanvien.GioiTinh;
                    lbGioiTinh.Visible = true;

                    dtNgaySinh.Enabled = false;

                    btnChonAnh.Visible = false;
                    btnLuu.Visible = false;

                    txtMatKhau.ReadOnly = true;
                    txtTenDangNhap.ReadOnly = true;
                    
                }
            }
        }
    }
}
