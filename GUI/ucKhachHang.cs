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
    public partial class ucKhachHang : UserControl
    {
        public KhachHang khachHang = new KhachHang();

        public ucKhachHang()
        {
            InitializeComponent();
        }
        public ucKhachHang(KhachHang kh)
        {
            InitializeComponent();
            this.khachHang = kh;
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            lbTenKH.Text = khachHang.TenKH;
            lbMaKH.Text = $"#{khachHang.MaKH}";
            lbRank.Text = khachHang.CapBac;
            switch (khachHang.MaCapBac)
            {
                case 1:
                    {
                        pbRank.Image = Properties.Resources.Bronze;
                        break;
                    }
                case 2:
                    {
                        pbRank.Image = Properties.Resources.Silver;
                        break;
                    }
                case 3:
                    {
                        pbRank.Image = Properties.Resources.Gold;
                        break;
                    }
                case 4:
                    {
                        lbRank.Text = "Kim cương";
                        pbRank.Image = Properties.Resources.Diamond;
                        break;
                    }
            }
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void guna2ShadowPanel2_Click(object sender, EventArgs e)
        {
            ucClick?.Invoke(this, e);
        }
        public event EventHandler ucClick;

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ucClick?.Invoke(this, e);
        }

        private void lbRank_Click(object sender, EventArgs e)
        {
            ucClick?.Invoke(this, e);
        }

        private void pbRank_Click(object sender, EventArgs e)
        {
            ucClick?.Invoke(this, e);
        }

        private void lbTenKH_Click(object sender, EventArgs e)
        {
            ucClick?.Invoke(this, e);
        }
    }
}
