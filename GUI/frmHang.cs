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
    public partial class frmHang : Form
    {
        public frmHang()
        {
            InitializeComponent();
        }

        
        public Hang LayThongTinHang()
        {
            string mahang = txtMaHang.Text;
            string tenhang = txtTenHang.Text;
            int baohanh = int.Parse(txtBaoHanh.Text);
            string xuatxu = txtXuatXu.Text;
            decimal gia = decimal.Parse(txtGia.Text);
            int sl = int.Parse(txtSL.Text);
            return new Hang(mahang, tenhang, baohanh, xuatxu, gia, sl);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangBLL.Instance.ThemHang(LayThongTinHang());
            this.Close();

        }

        private void frmHang_Load(object sender, EventArgs e)
        {

        }
    }
}
