using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string _maNV;
        private string _tenNV;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _diaChi;
        private string _SDT;
        private string _chucVu;

        public string MaNV { get => _maNV; set => _maNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string ChucVu { get => _chucVu; set => _chucVu = value; }

        public NhanVien(string maNV, string tenNV, string ngaySinh, string gioiTinh, string diaChi, string sDT, string chucVu)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SDT = sDT;
            ChucVu = chucVu;
        }
    }
}
