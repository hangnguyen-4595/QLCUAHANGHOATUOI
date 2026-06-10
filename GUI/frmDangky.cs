using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmDangky : Form
    {
        public frmDangky()
        {
            InitializeComponent();
            
        }
        private void lblTendangnhap_Click(object sender, EventArgs e)
        {
        }
        private void lblNhaplaimk_Click(object sender, EventArgs e)
        {
        }
        private void lblHoten_Click(object sender, EventArgs e)
        {
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtVaitro_SelectedIndexChanged(object sender, EventArgs e)
        {       
        }
        private void cboGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {         
        }
        private void frmDangky_Load(object sender, EventArgs e)
        {
           
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            
            cboVaitro.Items.Add("Nhân viên bán hàng");
            cboVaitro.Items.Add("Nhân viên kho");

            cboGioitinh.SelectedIndex = 0;
            cboVaitro.SelectedIndex = 0;
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            string tenDN = txtTendangnhap.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            string nhapLai = txtNhaplaimk.Text.Trim();
            string hoTen = txtHoten.Text.Trim();
            string sdt = guna2TextBox1.Text.Trim();  // ô Số ĐT
            string email = txtEmail.Text.Trim();
            string gt = cboGioitinh.SelectedItem?.ToString();
            string vaiTro = cboVaitro.SelectedItem?.ToString();
            string ngaySinh = dtpNgaysinh.Value.ToString("dd/MM/yyyy");
            // Validate
            if (string.IsNullOrEmpty(tenDN))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus(); return;
            }
            if (string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus(); return;
            }
            if (mk != nhapLai)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaplaimk.Clear(); txtNhaplaimk.Focus(); return;
            }
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus(); return;
            }
            // Kiểm tra trùng tên đăng nhập
            bool trung = TaiKhoanManager.DanhSach
                .Any(tk => tk.TenDangNhap.Equals(tenDN, StringComparison.OrdinalIgnoreCase));
            if (trung)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus(); return;
            }
            // Thêm tài khoản mới
            TaiKhoanManager.DanhSach.Add(new TaiKhoan
            {
                TenDangNhap = tenDN,
                MatKhau = mk,
                HoTen = hoTen,
                GioiTinh = gt,
                NgaySinh = ngaySinh,
                SoDT = sdt,
                Email = email,
                VaiTro = vaiTro
            });
            MessageBox.Show($"Đăng ký thành công!\nTài khoản: {tenDN}", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        

        private void lblDangky_Click(object sender, EventArgs e)
        {

        }
        private void frmLoadDangky(object sender, EventArgs e)
        {
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");

            cboVaitro.Items.Add("Nhân viên bán hàng");
            cboVaitro.Items.Add("Nhân viên kho");

            cboGioitinh.SelectedIndex = 0;
            cboVaitro.SelectedIndex = 0;
        }

    }
}
