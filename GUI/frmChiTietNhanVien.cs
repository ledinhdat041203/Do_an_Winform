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
    public partial class frmChiTietNhanVien : Form
    {
        public frmChiTietNhanVien()
        {
            InitializeComponent();
        }

        public frmChiTietNhanVien(NhanVien nv)
        {
            InitializeComponent();
            lb.Text = nv.MaNV + " " + nv.TenNV + " " + nv.NgaySinh + " " + nv.ChucVu;
        }

        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {

        }


    }
}
