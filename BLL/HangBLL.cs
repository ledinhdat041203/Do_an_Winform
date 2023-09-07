using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class HangBLL
    {
        private static HangBLL instance;
        public static HangBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangBLL();
                return instance;
            }
        }
        public DataTable LayDuLieuBLL()
        {
            return HangDAL.Instance.LayDuLieuDAL();
        }

        public bool ThemHang(Hang hang)
        {
            return HangDAL.Instance.ThemHang(hang);
        }
        public DataTable TimHangTheoTen(string ten)
        {
            return HangDAL.Instance.TimHangTheoTen(ten);
        }

        public string LayMa(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            return row.Cells["MaHang"].Value.ToString();
        }

        public bool XoaHang(string maHang)
        {
            return HangDAL.Instance.XoaHang(maHang);
        }
    }
}
