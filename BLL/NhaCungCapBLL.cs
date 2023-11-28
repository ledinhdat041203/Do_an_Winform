using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private static NhaCungCapBLL instance;
        public static NhaCungCapBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapBLL();
                return instance;
            }
        }

        public String findNCCByID(int maNCC)
        {
            return NhaCungCapDAL.Instance.findByID(maNCC);
        }

        public DataTable findAllTenNCC()
        {
            DataTable dt = NhaCungCapDAL.Instance.FindAll();
            return dt;
        }
    }
}
