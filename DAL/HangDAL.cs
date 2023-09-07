using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangDAL
    {
        private static HangDAL instance;
        public static HangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangDAL();
                return instance;
            }
        }
        public bool ThemHang(Hang hang)
        {
            SqlParameter[] param = 
            {
                new SqlParameter("@MaHang", hang.MaHang),
                new SqlParameter("@TenHang", hang.TenHang),
                new SqlParameter("@ThoiGianBaoHanh", hang.ThoiGianBaoHanh),
                new SqlParameter("@XuatXu", hang.XuatXu),
                new SqlParameter("@Gia", hang.Gia),
                new SqlParameter("@SoLuongCon", hang.SoLuongCon)
            };

            int result = DataBase.Instance.ThucThi("proc_themHang", param);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaHang(string mahang)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaHang", mahang)
            };

            int result = DataBase.Instance.ThucThi("proc_xoaHang", param);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable LayDuLieuDAL()
        {
            return DataBase.Instance.LayDuLieu("proc_select_all_hang", null);
        }

        public DataTable TimHangTheoTen(string ten)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@TenHang", ten)
            };
                return DataBase.Instance.LayDuLieu("proc_search_by_name", param);
        }
       
    }
}
