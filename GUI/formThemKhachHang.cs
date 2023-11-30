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
    public partial class formThemKhachHang : Form
    {
        private KhachHang khachHang = null;
        private bool isUpdate = false;


        public formThemKhachHang()
        {
            InitializeComponent();
        }

        public formThemKhachHang(KhachHang kh, bool isUpdate = false)
        {
            InitializeComponent();
            this.khachHang = kh;
            this.isUpdate = isUpdate;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.TenKH = $"{txtHo.Text} {txtTenDem.Text} {txtTenKH.Text}";
            kh.SDT = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.MaCapBac = 1;
            //kh.MaCapBac = cbCapBac.SelectedIndex + 1;
            if (khachHang == null)
            {
                if (KhachHangBLL.Instance.Insert(kh))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
            }
            else
            {
                kh.MaKH = khachHang.MaKH;
                if (KhachHangBLL.Instance.Update(kh))
                {
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                }
            }
        }

        private void formThemKhachHang_Load(object sender, EventArgs e)
        {
            if (khachHang == null)
            {

            }
            else if (isUpdate)
            {
                lbTieuDe.Text = "Thông tin khách hàng";
                txtDiaChi.Text = khachHang.DiaChi;
                txtSDT.Text = khachHang.SDT;

                string[] parts = khachHang.TenKH.Split(' ');

                if (parts.Length == 1)
                {

                    txtTenKH.Text = parts[0];

                }
                else if (parts.Length == 2)
                {
                    txtHo.Text = parts[0];
                    txtTenKH.Text = parts[1];
                }
                else
                {
                    txtHo.Text = parts[0];
                    txtTenKH.Text = parts[parts.Length - 1];
                    txtTenDem.Text = string.Join(" ", parts.Skip(1).Take(parts.Length - 2));
                }
            }
            else
            {
                //lbTieuDe.Text = "Thông tin khách hàng";
                txtDiaChi.Text = khachHang.DiaChi;
                txtSDT.Text = khachHang.SDT;
                string[] parts = khachHang.TenKH.Split(' ');

                if (parts.Length == 1)
                {

                    txtTenKH.Text = parts[0];

                }
                else if (parts.Length == 2)
                {
                    txtHo.Text = parts[0];
                    txtTenKH.Text = parts[1];
                }
                else
                {
                    txtHo.Text = parts[0];
                    txtTenKH.Text = parts[parts.Length - 1];
                    txtTenDem.Text = string.Join(" ", parts.Skip(1).Take(parts.Length - 2));
                }
                txtDiaChi.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtTenKH.ReadOnly = true;
                //cbCapBac.Enabled = false;
                btnLuu.Visible = false;
            }
        }

        
    }
}
