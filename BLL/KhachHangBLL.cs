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
    public class KhachHangBLL
    {
        private static KhachHangBLL instance;
        public static KhachHangBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBLL();
                return instance;
            }
        }

        public List<KhachHang> FindAll()
        {   
            List<KhachHang> list = new List<KhachHang>();
            DataTable dt = KhachHangDAL.Instance.FindAll();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(ConverDataRowToKH(row));
            }
            return list;
        }

        private KhachHang ConverDataRowToKH(DataRow row)
        {

            KhachHang kh = new KhachHang();
            kh.MaKH = int.Parse(row["MaKH"].ToString());
            kh.TenKH = row["HoTen"].ToString();
            kh.SDT = row["SDT"].ToString();
            kh.DiaChi = row["DiaChi"].ToString();
            kh.MaKH = int.Parse(row["MaKH"].ToString());
            kh.MaCapBac = int.Parse(row["MaCapBac"].ToString());
            kh.CapBac = row["TenCapBac"].ToString();

            return kh;
        }

        public bool Insert(KhachHang kh)
        {
            if (!Utils.Instance.checkPhone(kh.SDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return false;
            }
            if (!Utils.Instance.checkName(kh.TenKH))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ", "Thông báo");
                return false;
            }
            return KhachHangDAL.Instance.Insert(kh);
        }

        public bool Update(KhachHang kh)
        {
            if (!Utils.Instance.checkPhone(kh.SDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
                return false;
            }
            if (!Utils.Instance.checkName(kh.TenKH))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ", "Thông báo");
                return false;
            }
            return KhachHangDAL.Instance.Update(kh);
        }

        public DataTable FindBy(string tenKH, string capBac)
        {
            if (capBac == null)
                capBac = "";
            return KhachHangDAL.Instance.FindBy(tenKH, capBac);
        }

        public List<KhachHang> FindAllbyTenKH(string tenKH)
        {
            List<KhachHang> list = new List<KhachHang>();
            DataTable dt = KhachHangDAL.Instance.FindAllbyTenKH(tenKH);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(ConverDataRowToKH(row));
            }
            return list;
        }

        public string FindCapBacByMaKH(int maKH)
        {
            return KhachHangDAL.Instance.FindCapBacByMaKH(maKH);
        }

        public KhachHang FindByID(int maKH)
        {
            DataTable dt = KhachHangDAL.Instance.FindByID(maKH);
            DataRow row = dt.Rows[0];

            KhachHang kh = ConverDataRowToKH(row); 
            return kh;
        }
    }
}
