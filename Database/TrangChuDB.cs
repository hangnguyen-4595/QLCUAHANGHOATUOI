using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCUAHANGHOATUOI.Database
{
    public class TrangChuDB
    {
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCUAHANGHOATUOI;Integrated Security=True";

        public decimal LayDoanhThuHomNay()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        public int LaySoDonHangHomNay()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int LaySoDonDangXuLy()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM HoaDon WHERE TrangThai = N'Đang xử lý'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public DataTable LayXuHuongBanHangTuanNay()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DATEPART(WEEKDAY, NgayLap) AS Thu, COUNT(*) AS SoDon FROM HoaDon WHERE NgayLap >= DATEADD(DAY, -7, GETDATE()) GROUP BY DATEPART(WEEKDAY, NgayLap)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}