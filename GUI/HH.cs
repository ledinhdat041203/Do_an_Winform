using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class HH : Form
    {
        public HH()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna_pic_main);
            guna_pic_main.Image = ((Guna2PictureBox)sender).Image;
            guna2Transition1.ShowSync(guna_pic_main);

        }


        private void HH_Load(object sender, EventArgs e)
        {
            lbSLPA.Text = $"{HangBLL.Instance.DemHangByLoai(NTPB.Text)} sản phẩm";
            lbSLPK.Text = $"{HangBLL.Instance.DemHangByLoai(NTPK.Text)} sản phẩm";
            lbSLPN.Text = $"{HangBLL.Instance.DemHangByLoai(NTPN.Text)} sản phẩm";
            lbSLVP.Text = $"{HangBLL.Instance.DemHangByLoai(NTVP.Text)} sản phẩm";
        }

        private void btnNTVP_Click(object sender, EventArgs e)
        {
            frmQLHH fQLHH = new frmQLHH(NTVP.Text);
            fQLHH.ShowDialog();
        }

        private void btnNTPN_Click(object sender, EventArgs e)
        {
            frmQLHH fQLHH = new frmQLHH(NTPN.Text);
            fQLHH.ShowDialog();
        }

        private void btnNTPB_Click(object sender, EventArgs e)
        {
            frmQLHH fQLHH = new frmQLHH(NTPB.Text);
            fQLHH.ShowDialog();
        }

        private void btnNTPK_Click(object sender, EventArgs e)
        {
            frmQLHH fQLHH = new frmQLHH(NTPK.Text);
            fQLHH.ShowDialog();
        }
    }
}
