using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCUAHANGHOATUOI.Database
{
    public class NhanVienDB : DBconnect
    {
        public DataTable LayDanhSach()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaNhanVien, TenNV, Sdt, ChucVu, TrangThai, GioiTinh, NgaySinh FROM NhanVien";
            try
            {
                OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public bool Them(QLCUAHANGHOATUOI.Entity.NhanVien nv)
        {
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNV, Sdt, ChucVu, TrangThai, GioiTinh, NgaySinh) VALUES (@Ma, @Ten, @Sdt, @Chuc, @TrangThai, @Phai, @NgaySinh)";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@Ten", nv.TenNV);
                cmd.Parameters.AddWithValue("@Sdt", nv.Sdt);
                cmd.Parameters.AddWithValue("@Chuc", nv.ChucVu);
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
                cmd.Parameters.AddWithValue("@Phai", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool Sua(QLCUAHANGHOATUOI.Entity.NhanVien nv)
        {
            string query = "UPDATE NhanVien SET TenNV = @Ten, Sdt = @Sdt, ChucVu = @Chuc, TrangThai = @TrangThai, GioiTinh = @Phai, NgaySinh = @NgaySinh WHERE MaNhanVien = @Ma";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@Ten", nv.TenNV);
                cmd.Parameters.AddWithValue("@Sdt", nv.Sdt);
                cmd.Parameters.AddWithValue("@Chuc", nv.ChucVu);
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
                cmd.Parameters.AddWithValue("@Phai", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool Xoa(string maNhanVien)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @Ma";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maNhanVien);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}