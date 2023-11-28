using BLL;
using DTO;
using GUI;
using Guna.UI2.WinForms;
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
    public partial class frm_QuanLy : Form
    {
        private int a;
        public NhanVien nhanVien = new NhanVien();
        public frm_QuanLy()
        {
            InitializeComponent();
            a = guna2Panel1.Width;
        }

        public frm_QuanLy(NhanVien nv)
        {
            InitializeComponent();
            a = guna2Panel1.Width;
            this.nhanVien= nv;
        }

        private Form childForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (this.childForm != null)
            {
                this.childForm.Close();
            }
            this.childForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            if (guna2Panel1.Size.Width < 100)
            {
                guna2Panel1.Width = 160;
                guna2Transition1.ShowSync(guna2Panel1);
            }
            else
            {
                guna2Panel1.Width = a;
                guna2Transition1.ShowSync(guna2Panel1);
            }
        }


        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_BanHang());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLNV());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formKhachHang());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhapHang());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            if (nhanVien.MaNV == 0)
                nhanVien.MaNV = 1;
            else
            {
                pbAnh.Image = Utils.Instance.converByteToImage(nhanVien.Anh);
                lbTenNV.Text = nhanVien.TenNV;
                //lbChucVu.Text = nhanVien.ChucVu;
            }
           OpenChildForm(new frmQLNV());
        }

        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formDonHang());
        }

        
        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HH());
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
