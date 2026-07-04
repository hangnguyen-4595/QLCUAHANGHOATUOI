using System;
using System.Windows.Forms;
using QLCUAHANGHOATUOI.Database;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class UC_Taikhoan : UserControl
    {
        private readonly TaiKhoanDB taiKhoanDB = new TaiKhoanDB();

        public UC_Taikhoan()
        {
            InitializeComponent();
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            dgvTaikhoan.DataSource = taiKhoanDB.LayDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            QLCUAHANGHOATUOI.Entity.TaiKhoan tk = new QLCUAHANGHOATUOI.Entity.TaiKhoan
            {
                TenDangNhap = txtTentk.Text,
                MatKhau = txtMatkhau.Text,
                QuyenTruyCap = cboQuyen.Text,
                MaNhanVien = txtManv.Text
            };

            if (taiKhoanDB.Them(tk))
            {
                MessageBox.Show("Thêm thành công!");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            QLCUAHANGHOATUOI.Entity.TaiKhoan tk = new QLCUAHANGHOATUOI.Entity.TaiKhoan
            {
                TenDangNhap = txtTentk.Text,
                MatKhau = txtMatkhau.Text,
                QuyenTruyCap = cboQuyen.Text,
                MaNhanVien = txtManv.Text
            };

            if (taiKhoanDB.Sua(tk))
            {
                MessageBox.Show("Sửa thành công!");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenTK = txtTentk.Text;

            if (taiKhoanDB.Xoa(tenTK))
            {
                MessageBox.Show("Xóa thành công!");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void dgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaikhoan.Rows[e.RowIndex];
                txtTentk.Text = row.Cells["TenDangNhap"].Value?.ToString();
                cboQuyen.Text = row.Cells["QuyenTruyCap"].Value?.ToString();
                txtManv.Text = row.Cells["MaNhanVien"].Value?.ToString();
            }
        }
    }
}