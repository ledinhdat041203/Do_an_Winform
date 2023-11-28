using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TaiKhoanNVDAL
    {
        private static TaiKhoanNVDAL instance;
        public static TaiKhoanNVDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanNVDAL();
                return instance;
            }
        }
        /// <summary>
        /// kiem tra tai khoan, mat khau co dung khong
        /// </summary>
        public string checkLogin(TaiKhoanNV tk)
        {
            string user = null;
            DataBase.Instance.moKetNoi();
            DataBase.Instance.cmd = new SqlCommand("proc_login", DataBase.Instance.conn);
            DataBase.Instance.cmd.CommandType = CommandType.StoredProcedure;
            DataBase.Instance.cmd.Parameters.AddWithValue("@user", tk.taikhoan);
            DataBase.Instance.cmd.Parameters.AddWithValue("@pass", tk.matkhau);
            DataBase.Instance.cmd.Connection = DataBase.Instance.conn;
            DataBase.Instance.reader = DataBase.Instance.cmd.ExecuteReader();
            if (DataBase.Instance.reader.HasRows)
            {
                user = "successful";
            }
            else
            {
                user = "Tài khoản hoặc mật khẩu sai";
            }
            DataBase.Instance.reader.Close();
            DataBase.Instance.dongKetNoi();
            return user;

        }

        public int GetMaNV()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetMaNV";
            cmd.CommandType = CommandType.StoredProcedure;
            var retValParam = new SqlParameter("RetVal", SqlDbType.Int)
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(retValParam);
            DataBase.Instance.moKetNoi();
            cmd.Connection = DataBase.Instance.conn;
            cmd.ExecuteScalar();
            int maNV = int.Parse(retValParam.Value.ToString());
            DataBase.Instance.dongKetNoi();
            return maNV;
        }

        public bool Insert(TaiKhoanNV taiKhoanNV)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", taiKhoanNV.manv),
                new SqlParameter("@TenDangNhap", taiKhoanNV.taikhoan),
                new SqlParameter("@MatKhau", taiKhoanNV.matkhau)
            };
            try
            {
                int result = DataBase.Instance.ThucThi("proc_ThemTK", param);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FindByMaNV(int manv)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", manv),
            };
            return DataBase.Instance.LayDuLieu("proc_findTaiKhoanByMaNV", param);
        }

        public bool Update(TaiKhoanNV taiKhoanNV)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", taiKhoanNV.manv),
                new SqlParameter("@TenDangNhap", taiKhoanNV.taikhoan),
                new SqlParameter("@MatKhau", taiKhoanNV.matkhau)
            };
            try
            {
                int result = DataBase.Instance.ThucThi("proc_updateTK", param);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
