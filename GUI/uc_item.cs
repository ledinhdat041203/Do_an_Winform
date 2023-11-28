using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace GUI
{
    public partial class uc_item : UserControl
    {
        public Hang hang = new Hang();
        private bool isSale;

        public uc_item()
        {
            InitializeComponent();
        }

        public uc_item(Hang hang, bool isSale)
        {
            InitializeComponent();
            this.hang = hang;
            this.isSale = isSale;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            //lbTenHang.Visible = false;
            //btnChiTietSanPham.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            //lbTenHang.Visible = true;
            //btnChiTietSanPham.Visible = false;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            //lbDonGia.Visible = false;
            //btnThemVaoGioHang.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //lbDonGia.Visible = true;
            //btnThemVaoGioHang.Visible = false;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTietSanPham_Click(object sender, EventArgs e)
        {
            frm_ChiTietSanPham fCTSP = new frm_ChiTietSanPham(hang);
            fCTSP.ShowDialog();
        }

        private void uc_item_Load(object sender, EventArgs e)
        {
            btnChiTietSanPham.Visible = true;
            btnThemVaoGioHang.Visible = true;
            lbTenHang.Text = $"{hang.TenHang}";
            if (hang.Anh != null)
            {
                pcAnh.Image = converByteToImage(hang.Anh);
            }
            else
            {
                pcAnh.Image = Properties.Resources.box__1_;
            }
            if (isSale)
            {
                lbDonGia.Text = $"Giá bán: {hang.DonGia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
            }
            else
            {
                lbDonGia.Text = $"Giá Nhập: {hang.GiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"))}";
            }
        }

        public Image converByteToImage(Byte[] byteArr)
        {
            if (byteArr == null)
                return null;
            MemoryStream memoryStream = new MemoryStream(byteArr);
            return Image.FromStream(memoryStream);
        }

        //tạo sự kiện khi bấm vào nút thêm vào giỏ
        public event EventHandler ButtonAddClick;
        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            ButtonAddClick?.Invoke(this, e);
        }

        private void lbTenHang_Click(object sender, EventArgs e)
        {
            frmThongKe tk = new frmThongKe();
            tk.ShowDialog();
        }

        //private void lbDonGia_Click(object sender, EventArgs e)
        //{
        //    ButtonAddClick?.Invoke(this, e);
        //}
    }
}
