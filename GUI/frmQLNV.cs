using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class frmQLNV : Form
    {
        
        //private int currentRow = 0; // Dòng hiện tại
        public frmQLNV()
        {
            InitializeComponent();
        }
       

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LayDuLieu();
           
        }

        private void LayDuLieu()
        {
            flpNhanVien.Controls.Clear();
            flpQuanLi.Controls.Clear();
            List<NhanVien> list = NhanVienBLL.Instance.LayDuLieuBLL();
            foreach (NhanVien nv in list)
            {
                uc_NhanVien ucNhanVien = new uc_NhanVien(nv);
                ucNhanVien.updateNhanVien += ucNhanVien_Update;
                if (nv.ChucVu == "Quản lí")
                    flpQuanLi.Controls.Add(ucNhanVien);
                else
                {
                    
                    flpNhanVien.Controls.Add(ucNhanVien);

                }
            }
        }

        private void ucNhanVien_Update(object sender, EventArgs e)
        {
            LayDuLieu();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThem = new frmThemNhanVien();
            this.Hide();
            frmThem.ShowDialog();
            this.Show();
            LayDuLieu();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            formThemNhanVien fNhanVien = new formThemNhanVien();
            this.Hide();
            fNhanVien.ShowDialog();
            LayDuLieu();
            this.Show();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            flpNhanVien.Controls.Clear();
            List<NhanVien> list = NhanVienBLL.Instance.FindByTen(ten);
            foreach (NhanVien nv in list)
            {
                uc_NhanVien ucNhanVien = new uc_NhanVien(nv);
                ucNhanVien.updateNhanVien += ucNhanVien_Update;
                flpNhanVien.Controls.Add(ucNhanVien);
            }
        }
    }
}
