using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLCUAHANGHOATUOI.Database
{
    public class DBconnect
    {
        private string strConnect = @"Data Source=DESKTOP-P1JA9D7;Initial Catalog=QuanLyCHHoaTuoi;Integrated Security=True;TrustServerCertificate=True";

        protected SqlConnection conn = null;

        public DBconnect()
        {
            conn = new SqlConnection(strConnect);
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}