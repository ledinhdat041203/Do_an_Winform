using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_itemNhapHang : UserControl
    {
        public Hang hang = new Hang();

        public uc_itemNhapHang()
        {
            InitializeComponent();
        }

        public uc_itemNhapHang(Hang hang)
        {
            InitializeComponent();
            this.hang = hang;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_itemNhapHang_Load(object sender, EventArgs e)
        {
            lbTenHang.Text = $"Sản phẩm: {hang.TenHang}";
            lbGia.Text = $"{hang.GiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
            pbAnh.Image = Utils.Instance.converByteToImage(hang.Anh);
            lbNCC.Text = $"Nhà cung cấp: {hang.TenNCC}";
        }
        public event EventHandler ButtonAddClick;
        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            ButtonAddClick?.Invoke(this, e);
        }
    }
}
