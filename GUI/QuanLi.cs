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
    public partial class frmQuanLi : Form
    {
        public frmQuanLi()
        {
            InitializeComponent();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            this.Hide();
            frmQLNV.ShowDialog();
            this.Show();
        }

        private void btnQLHH_Click(object sender, EventArgs e)
        {
            frmQLHH frmQLHH = new frmQLHH();
            this.Hide();
            frmQLHH.ShowDialog();
            this.Show();
        }
    }
}
