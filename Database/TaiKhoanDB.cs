using System;
using System.Data;
using System.Data.SqlClient;
using QLCUAHANGHOATUOI.Entity;

namespace QLCUAHANGHOATUOI.Database
{
    public class TaiKhoanDB : DBconnect
    {
        public DataTable LayDanhSach()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TenDangNhap, QuyenTruyCap, MaNhanVien FROM TaiKhoan";
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

        public bool KiemTraTrungTenDN(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE LOWER(TenDangNhap) = LOWER(@Ten)";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
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

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau, out string quyenTruyCap)
        {
            quyenTruyCap = "";
            string query = "SELECT QuyenTruyCap FROM TaiKhoan WHERE TenDangNhap = @Ten AND MatKhau = @MK";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
                cmd.Parameters.AddWithValue("@MK", matKhau);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    quyenTruyCap = result.ToString(); 
                    return true;
                }
                return false;
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

        public bool Them(TaiKhoan tk)
        {
            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenTruyCap, MaNhanVien) VALUES (@Ten, @MK, @Quyen, @MaNV)";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MK", tk.MatKhau);
                cmd.Parameters.AddWithValue("@Quyen", tk.QuyenTruyCap);
                cmd.Parameters.AddWithValue("@MaNV", tk.MaNhanVien);
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

        public bool Sua(TaiKhoan tk)
        {
            string query = "UPDATE TaiKhoan SET MatKhau = @MK, QuyenTruyCap = @Quyen, MaNhanVien = @MaNV WHERE TenDangNhap = @Ten";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MK", tk.MatKhau);
                cmd.Parameters.AddWithValue("@Quyen", tk.QuyenTruyCap);
                cmd.Parameters.AddWithValue("@MaNV", tk.MaNhanVien);
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

        public bool Xoa(string tenDangNhap)
        {
            string query = "DELETE FROM TaiKhoan WHERE TenDangNhap = @Ten";
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
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