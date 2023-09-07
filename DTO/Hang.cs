using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang
    {
        private string _MaHang;
        private string _TenHang;
        private int _ThoiGianBaoHanh;
        private string _XuatXu;
        private decimal _Gia;
        private int _SoLuongCon;

        public int SoLuongCon { get => _SoLuongCon; set => _SoLuongCon = value; }
        public string MaHang { get => _MaHang; set => _MaHang = value; }
        public string TenHang { get => _TenHang; set => _TenHang = value; }
        public int ThoiGianBaoHanh { get => _ThoiGianBaoHanh; set => _ThoiGianBaoHanh = value; }
        public string XuatXu { get => _XuatXu; set => _XuatXu = value; }
        public decimal Gia { get => _Gia; set => _Gia = value; }

        public Hang(string maHang, string tenHang, int thoiGianBaoHanh, string xuatXu, decimal gia, int soLuongCon)
        {
            _MaHang = maHang;
            _TenHang = tenHang;
            _ThoiGianBaoHanh = thoiGianBaoHanh;
            _XuatXu = xuatXu;
            _Gia = gia;
            _SoLuongCon = soLuongCon;
        }

        public Hang()
        {
        }
    }
}
