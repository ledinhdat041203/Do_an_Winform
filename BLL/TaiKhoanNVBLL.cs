using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

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

        
    }
}
