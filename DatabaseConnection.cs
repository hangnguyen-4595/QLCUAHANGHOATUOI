using System;
using System.Data.SqlClient;

namespace QLCUAHANGHOATUOI
{
    public static class DatabaseConnection
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=dbCuaHangHoaTuoi;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    public static class Session
    {
        public static string MaNV { get; set; } = "NV001"; 
        public static string TenDangNhap { get; set; }
        public static string VaiTro { get; set; }
    }
}
