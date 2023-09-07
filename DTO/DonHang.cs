using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang
    {
        private string _maHoaDon;
        private string _MaKH;
        private string _MaNV;
        private string _NgayLap;
        private decimal _giaTri;
        private bool _trangThai;

        public string MaHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public decimal GiaTri { get => _giaTri; set => _giaTri = value; }
        public bool TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
