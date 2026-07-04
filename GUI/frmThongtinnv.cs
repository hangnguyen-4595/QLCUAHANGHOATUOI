using System;
using System.Windows.Forms;
using QLCUAHANGHOATUOI.Database;
using QLCUAHANGHOATUOI.Entity;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmThongtinnv : Form
    {
        private readonly bool isAddMode;
        private readonly NhanVienDB nhanVienDB = new NhanVienDB();

        
        public frmThongtinnv()
        {
            InitializeComponent();
            isAddMode = true;
            lblTieuDe.Text = "THÊM MỚI NHÂN VIÊN";
            txtMaNV.Enabled = true;

            
            dateTimePicker1.Value = DateTime.Now;
            if (guna2ComboBox1.Items.Count > 0) guna2ComboBox1.SelectedIndex = 0;
        }

        
        public frmThongtinnv(string ma, string ten, string chucVu, string sdt, string gioiTinh, DateTime ngaySinh)
        {
            InitializeComponent();
            isAddMode = false;
            lblTieuDe.Text = "CHỈNH SỬA THÔNG TIN";

            txtMaNV.Text = ma;
            txtMaNV.Enabled = false;
            txtTenNV.Text = ten;
            cboChucVu.Text = chucVu;
            txtSDT.Text = sdt;
            guna2ComboBox1.Text = gioiTinh;
            dateTimePicker1.Value = ngaySinh;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên nhân viên!", "Thông báo");
                return;
            }

            
            NhanVien nv = new NhanVien
            {
                MaNhanVien = txtMaNV.Text.Trim(),
                TenNV = txtTenNV.Text.Trim(),
                ChucVu = cboChucVu.Text,
                Sdt = txtSDT.Text.Trim(),
                GioiTinh = guna2ComboBox1.Text,
                NgaySinh = dateTimePicker1.Value,
                TrangThai = "Đang làm việc"
            };

            bool ketQua;
            if (isAddMode)
            {
                ketQua = nhanVienDB.Them(nv);
            }
            else
            {
                ketQua = nhanVienDB.Sua(nv);
            }

         
            if (ketQua)
            {
                MessageBox.Show(isAddMode ? "Thêm nhân viên thành công!" : "Cập nhật thông tin thành công!", "Thông báo");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại! Vui lòng kiểm tra lại dữ liệu hoặc mã nhân viên bị trùng.", "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblChucVu_Click(object sender, EventArgs e)
        {
            
        }
    }
}