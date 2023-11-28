using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThemSanPhamMoi : Form
    {
        public frm_ThemSanPhamMoi()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtTen.Text= "";
            txtXuatXu.Text = "";
            cbLoai.SelectedIndex = -1;
            cbNCC.SelectedIndex = -1;
            txtTen.Focus();
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

        private void frm_ThemSanPhamMoi_Load(object sender, EventArgs e)
        {
            pbAnh.Image = Properties.Resources.box__1_;

            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "MaLoai";
            DataTable dataTable = LoaiHangBLL.Instance.findAllLoai();
            cbLoai.DataSource = dataTable.DefaultView;
            cbLoai.SelectedIndex = -1;

            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";
            dataTable = NhaCungCapBLL.Instance.findAllTenNCC();
            cbNCC.DataSource = dataTable.DefaultView;
            cbNCC.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang.TenHang = txtTen.Text;
            hang.MaLoai = int.Parse(cbLoai.SelectedValue.ToString());
            hang.XuatXu = txtXuatXu.Text;
            hang.MaNCC = int.Parse(cbNCC.SelectedValue.ToString());
            try
            {
                hang.GiaNhap = decimal.Parse(txtGiaNhap.Text);
            }
            catch 
            {
                MessageBox.Show("Giá nhập không hợp lệ", "Thông báo");
                txtGiaNhap.Text = "";
                txtGiaNhap.Focus();
            }

            try
            {
                hang.DonGia = decimal.Parse(txtGiaBan.Text);
            }
            catch
            {
                MessageBox.Show("Giá bán không hợp lệ", "Thông báo");
                txtGiaBan.Text = "";
                txtGiaBan.Focus();
            }

            try
            {
                hang.BaoHanh = int.Parse(txtBaoHanh.Text);
            }
            catch
            {
                MessageBox.Show("Thời gian bảo hành không hợp lệ", "Thông báo");
                txtBaoHanh.Text = "";
                txtBaoHanh.Focus();
            }

            hang.Anh = Utils.Instance.ImageLocationToByteArray(pbAnh.ImageLocation);

            if (HangBLL.Instance.ThemHang(hang))
            {
                MessageBox.Show("Mặt hàng được thêm thành công", "Thông báo");
                onThemSanPham(EventArgs.Empty);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm hàng thất bại !!!", "Thông báo");
            }

        }

        public event EventHandler ThemSanPham;
        public void onThemSanPham( EventArgs e)
        {
            ThemSanPham?.Invoke(this, e);
        }
    }
}
