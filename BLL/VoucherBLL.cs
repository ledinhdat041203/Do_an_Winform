using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VoucherBLL
    {
        private static VoucherBLL instance;
        public static VoucherBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new VoucherBLL();
                return instance;
            }
        }

        public DataTable FindAll(DateTime ngaySD)
        {
            string strNgauSD = ngaySD.ToString("yyyy-MM-dd");
            return VoucherDAL.Instance.FindAll(strNgauSD);
        }
    }
    
}
