using System;
using System.Windows.Forms;
using QLCUAHANGHOATUOI.Database; 

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmDangnhap : Form
    {
      
        private readonly TaiKhoanDB taiKhoanDB = new TaiKhoanDB();

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            frmDangky frm = new frmDangky();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        private void ThucHienDangNhap()
        {
            string username = txtTaikhoan.Text.Trim();
            string password = txtMatkhau.Text.Trim();

            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                return;
            }

           
            string quyenTruyCap = "";
            if (taiKhoanDB.KiemTraDangNhap(username, password, out quyenTruyCap))
            {
                MessageBox.Show($"Đăng nhập thành công với quyền: {quyenTruyCap}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                if (quyenTruyCap == "Quản lý")
                {
                    frmManchinh frm = new frmManchinh();
                    frm.Show();
                }
                else if (quyenTruyCap == "Nhân viên")
                {
                    frmNhanvien frm = new frmNhanvien();
                    frm.Show();
                }

                this.Hide(); 
            }
            else
            {
                
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatkhau.Clear();
                txtMatkhau.Focus();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e) { }
        private void lblLogin_Click(object sender, EventArgs e) { }
        private void frmDangnhap_Load(object sender, EventArgs e) { }
        private void guna2Button3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}