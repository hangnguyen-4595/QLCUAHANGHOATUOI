using System;

namespace QLCUAHANGHOATUOI.Entity
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNV { get; set; }
        public string Sdt { get; set; }
        public string ChucVu { get; set; }
        public string TrangThai { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        public NhanVien() { }

        public NhanVien(string maNhanVien, string tenNV, string sdt, string chucVu, string trangThai, string gioiTinh, DateTime ngaySinh)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNV = tenNV;
            this.Sdt = sdt;
            this.ChucVu = chucVu;
            this.TrangThai = trangThai;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
        }
    }
}