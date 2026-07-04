using System;

namespace QLCUAHANGHOATUOI.Entity
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string QuyenTruyCap { get; set; }
        public string MaNhanVien { get; set; }

        public TaiKhoan() { }

        public TaiKhoan(string tenDangNhap, string matKhau, string quyenTruyCap, string maNhanVien)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.QuyenTruyCap = quyenTruyCap;
            this.MaNhanVien = maNhanVien;
        }
    }
}