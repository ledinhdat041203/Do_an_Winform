using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ChiTietSanPham : Form
    {
        Hang hang = new Hang();

        public frm_ChiTietSanPham()
        {
            InitializeComponent();
        }

        public frm_ChiTietSanPham(Hang hang)
        {
            InitializeComponent();
            this.hang = hang;
        }

        private void frm_ChiTietSanPham_Load(object sender, EventArgs e)
        {
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
    }
}
