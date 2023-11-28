using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DonNhapBLL
    {
        private static DonNhapBLL instance;
        public static DonNhapBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonNhapBLL();
                return instance;
            }
        }

        public bool Insert(int maNV)
        {
            return DonNhapDAL.Instance.Insert(maNV);
        }

        public int GetMaDon()
        {
            return DonNhapDAL.Instance.GetMaDon();
        }

        public decimal GetTongGTById(int maDon)
        {
            return DonNhapDAL.Instance.GetTongGTById(maDon);
        }

        public bool  UpdateThanhToan(int maDon)
        {
            return DonNhapDAL.Instance.UpdateThanhToan(maDon);
        }
    }
}
