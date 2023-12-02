using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLHH : Form
    {
        public string loaiSP;

        public frmQLHH()
        {
            InitializeComponent();
        }

        public frmQLHH(string loaihang)
        {
            InitializeComponent();
            this.loaiSP = loaihang;
        }

        private void loadCbNhaCungCap()
        {
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";
            DataTable dataTable = NhaCungCapBLL.Instance.findAllTenNCC();
            cbNCC.DataSource = dataTable.DefaultView;
            cbNCC.SelectedIndex = -1;
        }
        
        private void loadCbXuatXu()
        {
            cbXuatXu.DataSource = HangBLL.Instance.findAllXuatXu();
        }

        private void frmQLHH_Load(object sender, EventArgs e)
        {
            lbLoai.Text = loaiSP;
            LoadSP();
            loadCbNhaCungCap();
            loadCbXuatXu();
        }

        public void LoadSP()
        {
            dgvHang.DataSource = HangBLL.Instance.FindHang(loai: this.loaiSP);
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            
        }
        

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            //
        }


        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            DataGridViewRow row = dgvHang.SelectedCells[0].OwningRow;
            hang.MaHang = int.Parse(row.Cells["MaHang"].Value.ToString());
            hang.TenHang = row.Cells["TenHang"].Value.ToString();
            hang.DonGia = decimal.Parse(row.Cells["GiaBan"].Value.ToString());
            hang.GiaNhap = decimal.Parse(row.Cells["GiaNhap"].Value.ToString());
            hang.BaoHanh = int.Parse(row.Cells["BaoHanh"].Value.ToString());
            hang.XuatXu = row.Cells["XuatXu"].Value.ToString();
            hang.SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
            hang.Anh = (byte[])row.Cells["Anh"].Value;
            hang.TenNCC = row.Cells["TenNCC"].Value.ToString();
            hang.TenLoai = lbLoai.Text;

            frm_ThemSanPhamMoi fThemSP = new frm_ThemSanPhamMoi(hang);
            fThemSP.ShowDialog();
            LoadSP();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            findHang();
        }

        private void btnTatCa_Click_1(object sender, EventArgs e)
        {
            cbNCC.SelectedIndex = -1;
            cbXuatXu.SelectedIndex = -1;

            LoadSP() ;  
        }

        private void cbXuatXu_SelectedIndexChanged(object sender, EventArgs e)
        {
            findHang();
        }

        private void findHang()
        {
            string tenHang = txtTenHang.Text;
            string xuatXu = cbXuatXu.Text;
            string nhaCC = cbNCC.Text;

            dgvHang.DataSource = HangBLL.Instance.FindHang(tenHang, nhaCC, this.loaiSP, xuatXu);
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            findHang();
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Hang hang = new Hang();
            DataGridViewRow row = dgvHang.SelectedCells[0].OwningRow;
            hang.MaHang = int.Parse(row.Cells["MaHang"].Value.ToString());
            hang.TenHang = row.Cells["TenHang"].Value.ToString();
            hang.DonGia = decimal.Parse(row.Cells["GiaBan"].Value.ToString());
            hang.GiaNhap = decimal.Parse(row.Cells["GiaNhap"].Value.ToString());
            hang.BaoHanh = int.Parse(row.Cells["BaoHanh"].Value.ToString());
            hang.XuatXu = row.Cells["XuatXu"].Value.ToString();
            hang.SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
            hang.Anh = (byte[])row.Cells["Anh"].Value;
            hang.TenNCC = row.Cells["TenNCC"].Value.ToString();
            hang.TenLoai = lbLoai.Text;



            lbGiaBan.Text = hang.DonGia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            lbTen.Text = hang.TenHang;
            lbNCC.Text = hang.TenNCC;
            lbXuatXu.Text = hang.XuatXu;
            if (hang.Anh == null)
            {
                cbAnh.Image = Properties.Resources.box__1_;
            }
            else
            {
                cbAnh.Image = Utils.Instance.converByteToImage(hang.Anh);
            }

        }

        private void btnThemHang_Click_1(object sender, EventArgs e)
        {
            frm_ThemSanPhamMoi fThemSp = new frm_ThemSanPhamMoi();
            LoadSP();
            fThemSp.ShowDialog();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn muốn xóa mặt hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataGridViewRow row = dgvHang.SelectedCells[0].OwningRow;
                int maHang = int.Parse(row.Cells["MaHang"].Value.ToString());
                string TenHang = row.Cells["TenHang"].Value.ToString();
                if (HangBLL.Instance.XoaHang(maHang))
                {
                    MessageBox.Show($"Đã xóa {TenHang}","Thông báo");
                    LoadSP();
                }
                else
                {
                    MessageBox.Show($"Xóa hàng thất bại !!!", "Thông báo");
                }
            }    
        }
    }
}
