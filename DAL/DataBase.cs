using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataBase
    {
        private static DataBase instance;
        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataBase();
                return instance;
            }
        }
        private string strconn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLiCuaHang;Integrated Security=True";
        public SqlConnection conn = null;
        public SqlCommand cmd = null;
        public SqlDataReader reader = null;
        /// <summary>
        /// Ket noi database
        /// </summary>
        public  void ketNoiDB()
        {
            conn = new SqlConnection(strconn);
        }
        /// <summary>
        ///  mo ket noi
        /// </summary>
        public void moKetNoi()
        {
            if (conn == null)
            {
                ketNoiDB();
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        /// <summary>
        /// dong ket noi
        /// </summary>
        public void dongKetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable LayDuLieu(string procName, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
            moKetNoi();
            cmd.Connection= conn;
            //moKetNoi();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand= cmd;
            da.Fill(dt);
            dongKetNoi();
            return dt;
        }

        public int ThucThi(string procName, SqlParameter[] param)
        {
            cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (param != null)
            {
                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
            moKetNoi();
            cmd.Connection= conn;
            
            int row = cmd.ExecuteNonQuery();
            dongKetNoi();
            return row;       
        }
        
    }
}
