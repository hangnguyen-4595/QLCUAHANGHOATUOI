using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCUAHANGHOATUOI.GUI
{
    
        public class SanPham
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public string LoaiHoa { get; set; }
            public decimal GiaBan { get; set; }
            public int SoLuong { get; set; }
            public string NguonGoc { get; set; }

            public override string ToString()
            {
                return $"{MaSP} - {TenSP}";
            }
        }

        public static class SanPhamManager
        {
            public static List<SanPham> DanhSach = new List<SanPham>
        {
            new SanPham { MaSP="SP001", TenSP="Hoa Hồng", LoaiHoa="Hoa Bó",   GiaBan=150000, SoLuong=50, NguonGoc="Đà Lạt" },
            new SanPham { MaSP="SP002", TenSP="Hoa Ly",   LoaiHoa="Hoa Chậu", GiaBan=250000, SoLuong=20, NguonGoc="Huế" },
            new SanPham { MaSP="SP003", TenSP="Hoa Lan",  LoaiHoa="Hoa Chậu", GiaBan=500000, SoLuong=10, NguonGoc="Đà Nẵng" },
        };
        }
    }

