using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucChiTietDon : UserControl
    {
        public ChiTietDonHang CTDon;
        private Hang hang = new Hang();
        bool isSale = false;
        public ucChiTietDon()
        {
            InitializeComponent();
        }

        public ucChiTietDon(ChiTietDonHang CTDonNhap, bool isSale)
        {
            InitializeComponent();
            this.CTDon = CTDonNhap;
            this.isSale = isSale;
            this.hang = HangBLL.Instance.FindById(this.CTDon.MaHang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soLuong = CTDon.SoLuong;
            soLuong -= 1;
            if (soLuong > 0)
            {
                lbSoLuong.Text = (soLuong).ToString();
                CTDon.SoLuong = soLuong;
                if (!isSale)
                {
                    lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString();
                    ChiTietDonNhapBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, CTDon.SoLuong);
                }
                else
                {
                    lbThanhTien.Text = (soLuong * hang.DonGia).ToString();
                    ChiTietDonBanBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, CTDon.SoLuong);
                }
                OnSoLuongChanged(EventArgs.Empty);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int soLuong = CTDon.SoLuong;
            soLuong += 1;
            
            if (!isSale)
            {
                if (ChiTietDonNhapBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong))
                {
                    lbSoLuong.Text = soLuong.ToString();
                    CTDon.SoLuong = soLuong;
                    lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString();
                }
            }

            else
            {
                try
                {
                    ChiTietDonBanBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong);
                    lbThanhTien.Text = (soLuong * hang.DonGia).ToString();
                    lbSoLuong.Text = soLuong.ToString();
                    CTDon.SoLuong = soLuong;
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        if (error.Message.Contains("Khong co du hang"))
                        {
                            MessageBox.Show("Mặt hàng này hiện đã hết", "Thông báo");
                        }
                    }
                }


            }
            OnSoLuongChanged(EventArgs.Empty);
        }

        private void ucChiTietDon_Load(object sender, EventArgs e)
        {
            llbTenHang.Text = hang.TenHang.ToString();
            if (isSale)
                lbThanhTien.Text = hang.DonGia.ToString();
            else
                lbThanhTien.Text = hang.GiaNhap.ToString();
        }

        public event EventHandler SoLuongChanged;

        protected virtual void OnSoLuongChanged(EventArgs e)
        {
            SoLuongChanged?.Invoke(this, e);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
