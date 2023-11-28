using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class uc_itemSummary : UserControl
    {
        public ChiTietDonHang CTDon;
        private Hang hang = new Hang();
        bool isSale = false;

        public uc_itemSummary()
        {
            InitializeComponent();
        }

        public uc_itemSummary(ChiTietDonHang CTDon, bool isSale)
        {
            InitializeComponent();
            this.CTDon = CTDon;
            this.isSale = isSale;
            this.hang = HangBLL.Instance.FindById(this.CTDon.MaHang);
        }

        private void uc_itemSummary_Load(object sender, EventArgs e)
        {
            lbTenHang.Text = hang.TenHang;
            if (isSale)
            {
                txtSoLuong.Text = CTDon.SoLuong.ToString();
                lbDonGia.Text= hang.DonGia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                lbThanhTien.Text = hang.DonGia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            }
            else
            {
                lbDonGia.Text = hang.GiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                lbThanhTien.Text = hang.GiaNhap.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            }
        }

        
        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            //if (isHandlingEvent)
            //{
            //    return;
            //}
            //int soLuong = int.Parse(nudSoLuong.Value.ToString());
            //if (soLuong > 0)
            //{
            //    if (!isSale)
            //    {
            //        if (ChiTietDonNhapBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong))
            //        {
            //            CTDon.SoLuong = soLuong;
            //            lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            //            OnSoLuongDonNhapChanged(EventArgs.Empty);
            //        }
            //    }
            //    else
            //    {
            //        try
            //        {
            //            if (ChiTietDonBanBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong))
            //            {
            //                lbThanhTien.Text = (soLuong * hang.DonGia).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            //                CTDon.SoLuong = soLuong;
            //                OnSoLuongChanged(EventArgs.Empty);
            //            }
            //        }
            //        catch (SqlException ex)
            //        {
            //            //nudSoLuong.ValueChanged -= nudSoLuong_ValueChanged;
            //            //nudSoLuong.Value -= 1;
            //            //nudSoLuong.ValueChanged+= nudSoLuong_ValueChanged;
            //            foreach (SqlError error in ex.Errors)
            //            {
            //                if (error.Message.Contains("KHONG DU HANG"))
            //                {
            //                    MessageBox.Show("Mặt hàng này hiện đã hết", "Thông báo");
            //                    break;

            //                }
            //                else if (error.Message.Contains("don da thanh toan"))
            //                {
            //                    MessageBox.Show("Đơn hàng này đã được thanh toán !!", "Thông báo");
            //                    break;
            //                }
            //                else
            //                {
            //                    MessageBox.Show(error.Message);
            //                }

            //            }

            //        }
            //    }
            //}
                
        }

        //tạo sự kiện khi số lượng hàng thay đổi
        public event EventHandler SoLuongChanged;
        protected virtual void OnSoLuongChanged(EventArgs e)
        {
            SoLuongChanged?.Invoke(this, e);
        }

        //tạo sự kiện khi số lượng hàng thay đổi
        public event EventHandler SoLuongDonNhapChanged;
        protected virtual void OnSoLuongDonNhapChanged(EventArgs e)
        {
            SoLuongDonNhapChanged?.Invoke(this, e);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int soLuong = CTDon.SoLuong;
            soLuong -= 1;
            if (soLuong > 0)
            {
                if (!isSale)
                {
                    try
                    {
                        if (ChiTietDonNhapBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong))
                        {
                            CTDon.SoLuong = soLuong;
                            txtSoLuong.Text = soLuong.ToString();
                            lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                            OnSoLuongDonNhapChanged(EventArgs.Empty);
                        }
                    }
                    catch (SqlException ex)
                    {
                        foreach (SqlError error in ex.Errors)
                        {
                            if (error.Message.Contains("don da thanh toan"))
                            {
                                MessageBox.Show("Đơn hàng này đã được thanh toán !!", "Thông báo");
                                break;
                            }
                            else
                            {
                                MessageBox.Show(error.Message);
                            }
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (ChiTietDonBanBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong))
                        {
                            CTDon.SoLuong = soLuong;
                            txtSoLuong.Text = soLuong.ToString();
                            lbThanhTien.Text = (soLuong * hang.DonGia).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                            CTDon.SoLuong = soLuong;
                            OnSoLuongChanged(EventArgs.Empty);
                        }
                    }
                    catch (SqlException ex)
                    {

                        foreach (SqlError error in ex.Errors)
                        {
                            if (error.Message.Contains("don da thanh toan"))
                            {
                                MessageBox.Show("Đơn hàng này đã được thanh toán !!", "Thông báo");
                                break;
                            }
                            else
                            {
                                MessageBox.Show(error.Message);
                            }
                        }
                    }
                }

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
                    CTDon.SoLuong = soLuong;
                    txtSoLuong.Text = soLuong.ToString();
                    lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                    OnSoLuongDonNhapChanged(EventArgs.Empty);
                }
            }
            else
            {
                try
                {
                    if (ChiTietDonBanBLL.Instance.UpdateSoLuongHang(CTDon.MaChiTiet, soLuong))
                    {
                        CTDon.SoLuong = soLuong;
                        txtSoLuong.Text = soLuong.ToString();
                        lbThanhTien.Text = (soLuong * hang.DonGia).ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                        CTDon.SoLuong = soLuong;
                        OnSoLuongChanged(EventArgs.Empty);
                    }
                }
                catch (SqlException ex)
                {

                    foreach (SqlError error in ex.Errors)
                    {
                        if (error.Message.Contains("don da thanh toan"))
                        {
                            MessageBox.Show("Đơn hàng này đã được thanh toán !!", "Thông báo");
                            break;
                        }
                        else if (error.Message.Contains("KHONG DU HANG"))
                        {
                            MessageBox.Show("Mặt hàng này hiện đã hết", "Thông báo");
                            break;
                        }
                        else
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                }
            }

        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSale && ChiTietDonBanBLL.Instance.XoaChiTiet(CTDon.MaChiTiet))
                {
                    MessageBox.Show("Đã xóa mặt hàng này ra khỏi đơn", "Thông báo");
                    this.Visible = false;
                }
                else
                    if (!isSale && ChiTietDonNhapBLL.Instance.XoaChiTiet(CTDon.MaChiTiet))
                    {
                    MessageBox.Show("Đã xóa mặt hàng này ra khỏi đơn", "Thông báo");
                    this.Visible = false;
                    }
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    if (error.Message.Contains("don da thanh toan"))
                    {
                        MessageBox.Show("Đơn hàng này đã được thanh toán !!", "Thông báo");
                        break;
                    }
                    else
                    { MessageBox.Show(error.Message); }
                }
            }
        }
    }
}
