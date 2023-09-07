using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTaiKhoan.Text == "Your Name")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Your Name")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password")
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "Your Name";
                txtTaiKhoan.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Password";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btnShowPass.BackgroundImage = global::GUI.Properties.Resources.hide_2767146;
                txtMatKhau.PasswordChar = '*';
            }
            else
            {
                btnShowPass.BackgroundImage = global::GUI.Properties.Resources.eye_3926043;
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            TaiKhoanNV tk =new TaiKhoanNV();
            tk.taikhoan= ten;
            tk.matkhau= matkhau;
            TaiKhoanNVBLL tkBLL = new TaiKhoanNVBLL();
            string result = tkBLL.checkLogin(tk);
            if (result == "succerful")
            {
                frmQuanLi frmQuanLi = new frmQuanLi();
                this.Hide();
                frmQuanLi.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
