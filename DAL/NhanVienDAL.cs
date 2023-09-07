using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;
        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAL();
                return instance;
            }
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@ChucVu", nv.ChucVu)
            };
            
            int result = DataBase.Instance.ThucThi("proc_themNV", param);
            if (result>0)
            {
                return true;
            }
            return false;
        }
        public DataTable LayDuLieuDAL()
        {
            return DataBase.Instance.LayDuLieu("proc_select_all_NV", null);
        }
        
    }
}
