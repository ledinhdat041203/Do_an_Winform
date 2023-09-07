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
    public partial class frmQLHH : Form
    {
        public frmQLHH()
        {
            InitializeComponent();
            LayDuLieuGui();
        }
        public void LayDuLieuGui()
        {
            dgvHang.DataSource = HangBLL.Instance.LayDuLieuBLL();
        }

        public void  ThemHang(Hang hang)
        {
            if (HangBLL.Instance.ThemHang(hang))
            {
                MessageBox.Show("Thêm hàng thành công");
                LayDuLieuGui();
            }
            else
                MessageBox.Show("Thêm thất bại");    
        }
           

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            frmHang f = new frmHang();
            f.ShowDialog();
            LayDuLieuGui();
        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtMaHang.Text;
            dgvHang.DataSource = HangBLL.Instance.TimHangTheoTen(ten);
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LayDuLieuGui();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Sửa thành công");
                LayDuLieuGui();
            }
            else
                MessageBox.Show("Sửa Thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Xóa ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maHang = HangBLL.Instance.LayMa(dgvHang);
                if (HangBLL.Instance.XoaHang(maHang))
                {
                    MessageBox.Show("Xóa thành công");
                    LayDuLieuGui();
                }
                else
                    MessageBox.Show("Xóa Thất bại");
            }
        }
    }
}
