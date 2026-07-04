using QLCUAHANGHOATUOI.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class UC_Sanpham : UserControl
    {
        private readonly SanPhamDB sanPhamDB = new SanPhamDB();

        public UC_Sanpham()
        {
            InitializeComponent();
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            dgvSanpham.DataSource = sanPhamDB.LayDanhSach();
        }

        private void LamMoiOChon()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            numSoLuong.Value = 0;
            txtGia.Clear();
            cboPhanLoai.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text) || string.IsNullOrEmpty(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mã và tên sản phẩm!", "Thông báo");
                return;
            }

            if (sanPhamDB.Them(txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), (int)numSoLuong.Value, txtGia.Text.Trim(), cboPhanLoai.Text, cboTrangThai.Text))
            {
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                HienThiDuLieu();
                LamMoiOChon();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại! Mã sản phẩm có thể đã tồn tại.", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa từ bảng!", "Thông báo");
                return;
            }

            if (sanPhamDB.Sua(txtMaSP.Text.Trim(), txtTenSP.Text.Trim(), (int)numSoLuong.Value, txtGia.Text.Trim(), cboPhanLoai.Text, cboTrangThai.Text))
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo");
                HienThiDuLieu();
                LamMoiOChon();
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại!", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ bảng!", "Thông báo");
                return;
            }

            DialogResult kq = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm mã {txtMaSP.Text} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                if (sanPhamDB.Xoa(txtMaSP.Text.Trim()))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                    HienThiDuLieu();
                    LamMoiOChon();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Sản phẩm này có thể đang tồn tại trong các hóa đơn.", "Lỗi");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDuLieu();
            LamMoiOChon();
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanpham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["Mã SP"].Value?.ToString();
                txtTenSP.Text = row.Cells["Tên SP"].Value?.ToString();
                txtGia.Text = row.Cells["Giá"].Value?.ToString();
                cboPhanLoai.Text = row.Cells["Phân loại"].Value?.ToString();
                cboTrangThai.Text = row.Cells["Trạng thái"].Value?.ToString();

                if (row.Cells["Ref_Cột_Số_Lượng_Thật"].Value != null && int.TryParse(row.Cells["Số lượng"].Value.ToString(), out int sl))
                {
                    numSoLuong.Value = sl;
                }
                else
                {
                    numSoLuong.Value = 0;
                }
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

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {

        }
    }
}