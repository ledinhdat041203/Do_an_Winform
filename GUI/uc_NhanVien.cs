using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class uc_NhanVien : UserControl
    {
        private NhanVien nhanvien = new NhanVien();
        private NhanVien currentNhanVien = new NhanVien();
        public uc_NhanVien()
        {
            InitializeComponent();
        }

        public uc_NhanVien(NhanVien nv)
        {
            InitializeComponent();
            this.nhanvien = nv;
        }

        private void pbAnh_Click(object sender, EventArgs e)
        {

        }

        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            lbTen.Text = nhanvien.TenNV;
            lbDiaChi.Text = nhanvien.DiaChi;
            lbSDT.Text = nhanvien.SDT;
            lbChucVu.Text = nhanvien.ChucVu;
            pbAnh.Image = Utils.Instance.converByteToImage(nhanvien.Anh);
            lbMaNV.Text = $"#{nhanvien.MaNV}";
            if (nhanvien.ChucVu == "Quản lí")
            {
                btnXoa.Visible = false;
            }


            //lấy thông tin nhân viên tạo đơn từ formQuanLi
            frm_QuanLy frmQL = Application.OpenForms.OfType<frm_QuanLy>().FirstOrDefault();
            NhanVien nhanVienDangNhap = frmQL.nhanVien;
            this.currentNhanVien = nhanVienDangNhap;
            if (currentNhanVien.ChucVu != "Quản lí")
            {
                btnInfo.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
        }
        public event EventHandler updateNhanVien;
        protected virtual void OnUpdateNhanVien(EventArgs e)
        {
            updateNhanVien?.Invoke(this, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            formThemNhanVien fThemNV = new formThemNhanVien(nhanvien, isUpdate: true);
            fThemNV.ShowDialog();
            OnUpdateNhanVien(EventArgs.Empty);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            formThemNhanVien fThemNV = new formThemNhanVien(nhanvien);
            fThemNV.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (NhanVienBLL.Instance.XoaNhanVien(nhanvien.MaNV))
                {
                    MessageBox.Show("Xóa Thành công", "Thông Báo");
                    OnUpdateNhanVien(EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }
            }
        }
    }
}
