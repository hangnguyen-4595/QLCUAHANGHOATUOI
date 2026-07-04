using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCUAHANGHOATUOI.Database
{
    public class KhachHangDB
    {
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCUAHANGHOATUOI;Integrated Security=True";

        public DataTable LayDanhSach()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaKH AS [Mã KH], TenKH AS [Tên KH], SDT AS [SĐT], DiaChi AS [Địa chỉ] FROM KhachHang";
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

        public bool Them(string maKH, string tenKH, string sdt, string diaChi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KhachHang (MaKH, TenKH, SDT, DiaChi) VALUES (@MaKH, @TenKH, @SDT, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Sua(string maKH, string tenKH, string sdt, string diaChi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE KhachHang SET TenKH = @TenKH, SDT = @SDT, DiaChi = @DiaChi WHERE MaKH = @MaKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Xoa(string maKH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}