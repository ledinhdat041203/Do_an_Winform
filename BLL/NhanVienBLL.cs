using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
using System.Windows.Forms;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBLL();
                return instance;
            }
        }
        public DataTable LayDuLieuBLL()
        {
            return NhanVienDAL.Instance.LayDuLieuDAL();
        }

        public NhanVien  ChiTietNhanVien(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string manv = row.Cells["MaNV"].Value.ToString();
            string tennv = row.Cells["TenNV"].Value.ToString();
            string ngaysinh = row.Cells["NgaySinh"].Value.ToString();
            string gioitinh = row.Cells["GioiTinh"].Value.ToString();
            string diachi = row.Cells["DiaChi"].Value.ToString();
            string sdt = row.Cells["SDT"].Value.ToString();
            string chucvu = row.Cells["ChucVu"].Value.ToString();
            return new NhanVien(manv, tennv, ngaysinh, gioitinh, diachi, sdt, chucvu);
        }

    }
}
