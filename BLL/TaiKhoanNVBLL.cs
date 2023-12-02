using DAL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class TaiKhoanNVBLL
    {
        private static TaiKhoanNVBLL instance;
        public static TaiKhoanNVBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanNVBLL();
                return instance;
            }
        }
        public string checkLogin(TaiKhoanNV tk)
        {
            if (tk.taikhoan == "")
                return "empty account";
            if (tk.matkhau == "")
                return "empty password";
            return TaiKhoanNVDAL.Instance.checkLogin(tk);
        }
        public int GetMaNV()
        {
            return TaiKhoanNVDAL.Instance.GetMaNV();
        }

        public bool Insert(TaiKhoanNV taiKhoanNV)
        {
            if (taiKhoanNV.taikhoan == "" || taiKhoanNV.matkhau == "")
            {
                MessageBox.Show("không được để trống tài khoản và mật khẩu !!!", "Thông báo");
                return false;
            }
            try
            {
                return TaiKhoanNVDAL.Instance.Insert(taiKhoanNV);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public TaiKhoanNV FindByMaNV(int manv)
        {
            TaiKhoanNV tk = new TaiKhoanNV();
            DataTable dt = TaiKhoanNVDAL.Instance.FindByMaNV(manv);
            DataRow dataRow = dt.Rows[0];
            tk.manv = manv;
            tk.taikhoan = dataRow["TenDangNhap"].ToString();
            tk.matkhau = dataRow["MatKhau"].ToString();

            return tk;
        }

        public bool Update(TaiKhoanNV taiKhoanNV)
        {
            if (taiKhoanNV.taikhoan == "" || taiKhoanNV.matkhau == "")
            {
                MessageBox.Show("không được để trống tài khoản và mật khẩu !!!", "Thông báo");
                return false;
            }
            try
            {
                return TaiKhoanNVDAL.Instance.Update(taiKhoanNV);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

    }
}
