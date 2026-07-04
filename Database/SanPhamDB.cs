using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCUAHANGHOATUOI.Database
{
    public class SanPhamDB
    {
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCUAHANGHOATUOI;Integrated Security=True";

        public DataTable LayDanhSach()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaSP AS [Mã SP], TenSP AS [Tên SP], SoLuong AS [Số lượng], Gia AS [Giá], PhanLoai AS [Phân loại], TrangThai AS [Trạng thái] FROM SanPham";
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

        public bool Them(string maSP, string tenSP, int soLuong, string gia, string phanLoai, string trangThai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SanPham (MaSP, TenSP, SoLuong, Gia, PhanLoai, TrangThai) VALUES (@MaSP, @TenSP, @SoLuong, @Gia, @PhanLoai, @TrangThai)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@PhanLoai", phanLoai);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Sua(string maSP, string tenSP, int soLuong, string gia, string phanLoai, string trangThai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SanPham SET TenSP = @TenSP, SoLuong = @SoLuong, Gia = @Gia, PhanLoai = @PhanLoai, TrangThai = @TrangThai WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@TenSP", tenSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@Gia", gia);
                    cmd.Parameters.AddWithValue("@PhanLoai", phanLoai);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Xoa(string maSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}