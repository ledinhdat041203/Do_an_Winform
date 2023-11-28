using BLL;
using DTO;
using System;
using System.Data;
using System.Drawing;
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
        private bool checkKeyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                return false;
            return true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenHang = txtTenHang.Text;
            string xuatXu = cbXuatXu.Text;
            string nhaCC = cbNCC.Text;
           
            //dgvHang.DataSource = HangBLL.Instance.FindHang(tenHang, nhaCC,loai,xuatXu);
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            //
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn Muốn Xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    string maHang = HangBLL.Instance.LayHang(dgvHang).MaHang;
            //    if (HangBLL.Instance.XoaHang(maHang))
            //    {
            //        MessageBox.Show("Xóa thành công");
            //        LayDuLieu();
            //    }
            //    else
            //        MessageBox.Show("Xóa Thất bại");
            //}
        }
        
        
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Hang hang = HangBLL.Instance.LayHang(dgvHang);

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
    }
}
