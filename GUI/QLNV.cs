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
    public partial class frmQLNV : Form
    {
        
        public frmQLNV()
        {
            InitializeComponent();
            LayDuLieuGui();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LayDuLieuGui()
        { 
            dgvNhanVien.DataSource= NhanVienBLL.Instance.LayDuLieuBLL();
        }

        

        private void dgvNhanVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nv = NhanVienBLL.Instance.ChiTietNhanVien(dgvNhanVien);
            showNhanVien(nv);
        }

        public void showNhanVien(NhanVien nv)
        {
            frmChiTietNhanVien f = new frmChiTietNhanVien(nv);
            f.ShowDialog();
            
            
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
