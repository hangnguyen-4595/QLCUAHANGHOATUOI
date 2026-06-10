using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLCUAHANGHOATUOI.GUI
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public string VaiTro { get; set; }
    }

    public static class TaiKhoanManager
    {
        public static List<TaiKhoan> DanhSach = new List<TaiKhoan>
        {
            new TaiKhoan { TenDangNhap = "admin",  MatKhau = "123",  HoTen = "Admin",     GioiTinh = "Nam", VaiTro = "Quản lý" },
            new TaiKhoan { TenDangNhap = "admin1", MatKhau = "1234", HoTen = "Nhân viên", GioiTinh = "Nam", VaiTro = "Nhân viên bán hàng" }
        };
    }
}
