using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLNVOLD : Form
    {
        public frmQLNVOLD()
        {
            InitializeComponent();
        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void LayDuLieu()
        {
            dgvNhanVien.DataSource = NhanVienBLL.Instance.LayDuLieuBLL();
        }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThem = new frmThemNhanVien();
            this.Hide();
            frmThem.ShowDialog();
            this.Show();
            LayDuLieu();
        }

        private void btnThemNV_MouseHover(object sender, EventArgs e)
        {
            btnThemNV.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void btnThemNV_MouseLeave(object sender, EventArgs e)
        {
            btnThemNV.BackColor = Color.White;
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                NhanVien nv = NhanVienBLL.Instance.ChiTietNhanVien(dgvNhanVien);
                frmThongTinNhanVien frmThongTin = new frmThongTinNhanVien(nv,isEdit: true);
                this.Hide();
                frmThongTin.ShowDialog();
                this.Show();
                LayDuLieu();
            }
            else
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo");
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.SelectedCells.Count > 0)
            {
                NhanVien nv = NhanVienBLL.Instance.ChiTietNhanVien(dgvNhanVien);
                frmThongTinNhanVien frmThongTinNhanVien = new frmThongTinNhanVien(nv);
                this.Hide();
                frmThongTinNhanVien.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataGridViewRow row = dgvNhanVien.SelectedCells[0].OwningRow;
                //int maNV = row.Cells["MaNV"].Value.ToString();
                int maNV =1;
                if (NhanVienBLL.Instance.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa Thành công", "Thông Báo");
                    LayDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }
            }

        }

        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
