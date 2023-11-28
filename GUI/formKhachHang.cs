using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections;
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
    public partial class formKhachHang : Form
    {
        private Guna2Button currentBtn;
        private Panel underBorderBtn;
        public formKhachHang()
        {
            
            InitializeComponent();

            underBorderBtn = new Panel();
            panelDetailCustomer.Controls.Add(underBorderBtn);
        }
        private void InitButton() { 
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0,0,0);
        }
        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                currentBtn = (Guna2Button)sender;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                underBorderBtn.Size = new Size(currentBtn.Width,3);
                underBorderBtn.BackColor = color;
                underBorderBtn.Location = new Point(currentBtn.Location.X,35);
                underBorderBtn.Visible = true;
                underBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(254,254,254);
                currentBtn.ForeColor = Color.Gray;
            }
        }
        
        private void btnInforCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            panelRank.Visible = false;
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            panelRank.Visible = true;
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            FindAllKhachHang()
;        }

        private void FindAllKhachHang()
        {
            flpKhachHang.Controls.Clear();
            List<KhachHang> list = KhachHangBLL.Instance.FindAll();
            foreach (KhachHang kh in list)
            {
                ucKhachHang ucKH = new ucKhachHang(kh);
                flpKhachHang.Controls.Add(ucKH);
                ucKH.ucClick += clickucKH;
            }
        }

        private void clickucKH(object sender, EventArgs e)
        {
            ucKhachHang clickedItem = sender as ucKhachHang;
            KhachHang khachHang = clickedItem.khachHang;
            lbTenKH.Text = khachHang.TenKH;
            lbDiaChi.Text = khachHang.DiaChi;
            lbSDT.Text = khachHang.SDT;
            lbRank.Text = khachHang.CapBac;
            lbmaKH.Text = $"#{khachHang.MaKH.ToString()}";
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
                        pbRank.Image = Properties.Resources.Diamond;
                        break;
                    }
            }

            btnSuaThongTin.Tag = khachHang;
            btnXoa.Tag = khachHang;


            List<DonBan> list = DonBanBLL.Instance.FindByMaKH(clickedItem.khachHang.MaKH);
            dgvKhachHang.DataSource = list;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            formThemKhachHang addKH = new formThemKhachHang();
            addKH.ShowDialog();
            FindAllKhachHang();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (btnSuaThongTin.Tag != null)
            {
                KhachHang kh = btnSuaThongTin.Tag as KhachHang;
                formThemKhachHang addKH = new formThemKhachHang(kh, isUpdate: true);
                addKH.ShowDialog();
                FindAllKhachHang();
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            flpKhachHang.Controls.Clear();
            List<KhachHang> list = KhachHangBLL.Instance.FindAllbyTenKH(tenKH);
            foreach (KhachHang kh in list)
            {
                ucKhachHang ucKH = new ucKhachHang(kh);
                flpKhachHang.Controls.Add(ucKH);
                ucKH.ucClick += clickucKH;
            }
        }


        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DonBan donban = new DonBan();
            DataGridViewRow row = dgvKhachHang.SelectedCells[0].OwningRow;
            donban.MaNV = int.Parse(row.Cells["MaNV"].Value.ToString());
            donban.MaDon = int.Parse(row.Cells["MaDon"].Value.ToString());
            donban.MaKH = int.Parse(row.Cells["MaKH"].Value.ToString());
            donban.TenKH = row.Cells["TenKH"].Value.ToString();
            donban.ThanhTien = decimal.Parse(row.Cells["ThanhTien"].Value.ToString());
            donban.TongGT = decimal.Parse(row.Cells["TongGT"].Value.ToString());
            donban.ChieuKhau = decimal.Parse(row.Cells["ChietKhau"].Value.ToString());
            donban.VAT = decimal.Parse(row.Cells["VAT"].Value.ToString());
            donban.NgayTao = row.Cells["NgayTao"].Value.ToString();
            donban.TrangThai = row.Cells["TrangThai"].Value.ToString();
            donban.MaVoucher = int.Parse(row.Cells["MaVoucher"].Value.ToString());

            formChiTietDonHang fCTDonHang = new formChiTietDonHang(donban);
            this.Hide();
            fCTDonHang.ShowDialog();
            List<DonBan> list = DonBanBLL.Instance.FindByMaKH(donban.MaKH);
            dgvKhachHang.DataSource = list;
            this.Show();
        }
    }
}
