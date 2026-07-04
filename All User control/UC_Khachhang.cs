using QLCUAHANGHOATUOI.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class UC_Khachhang : UserControl
    {
        private readonly KhachHangDB khachHangDB = new KhachHangDB();

        public UC_Khachhang()
        {
            InitializeComponent();
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            dgvKhachhang.DataSource = khachHangDB.LayDanhSach();
        }

        private void LamMoiOChon()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên khách hàng!", "Thông báo");
                return;
            }

            if (khachHangDB.Them(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim()))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                HienThiDuLieu();
                LamMoiOChon();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Mã khách hàng có thể đã tồn tại.", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ bảng!", "Thông báo");
                return;
            }

            if (khachHangDB.Sua(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim()))
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo");
                HienThiDuLieu();
                LamMoiOChon();
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa từ bảng!", "Thông báo");
                return;
            }

            DialogResult kq = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng mã {txtMaKH.Text} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                if (khachHangDB.Xoa(txtMaKH.Text.Trim()))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                    HienThiDuLieu();
                    LamMoiOChon();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Khách hàng này có thể đang có lịch sử hóa đơn mua hàng.", "Lỗi");
                }
            }
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachhang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["Mã KH"].Value?.ToString();
                txtTenKH.Text = row.Cells["Tên KH"].Value?.ToString();
                txtSDT.Text = row.Cells["SĐT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["Địa chỉ"].Value?.ToString();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}