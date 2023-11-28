using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiHangBLL
    {
        private static LoaiHangBLL instance;
        public static LoaiHangBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiHangBLL();
                return instance;
            }
        }
        public DataTable findAllLoai()
        {
            DataTable dt = LoaiHangDAL.Instance.findAll();

            return dt;
        }
        public String findLoaiByID(int maLoai)
        {
            return LoaiHangDAL.Instance.findLoaiByID(maLoai);
        }
    }
}
