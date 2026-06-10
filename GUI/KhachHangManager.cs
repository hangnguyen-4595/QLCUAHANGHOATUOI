using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANGHOATUOI.GUI
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }

        public override string ToString()
        {
            return $"{MaKH} - {TenKH}";
        }
    }

    public static class KhachHangManager
    {
        public static List<KhachHang> DanhSach = new List<KhachHang>
        {
            new KhachHang { MaKH="KH001", TenKH="Nguyễn Văn A", SoDT="0905123456", DiaChi="Huế" },
            new KhachHang { MaKH="KH002", TenKH="Trần Thị B",   SoDT="0912345678", DiaChi="Đà Nẵng" },
            new KhachHang { MaKH="KH003", TenKH="Lê Văn C",     SoDT="0987654321", DiaChi="Quảng Trị" },
        };
    }
}