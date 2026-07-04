using System;
using System.Windows.Forms;
using QLCUAHANGHOATUOI.Database;
using QLCUAHANGHOATUOI.Entity; 

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmDangky : Form
    {
        
        private readonly TaiKhoanDB taiKhoanDB = new TaiKhoanDB();

        public frmDangky()
        {
            InitializeComponent();
        }

        private void frmDangky_Load(object sender, EventArgs e)
        {
         
            cboGioitinh.Items.Clear();
            cboGioitinh.Items.Add("Nam");
            cboGioitinh.Items.Add("Nữ");
            cboGioitinh.SelectedIndex = 0;

           
            cboVaitro.Items.Clear();
            cboVaitro.Items.Add("Quản lý");
            cboVaitro.Items.Add("Nhân viên");
            cboVaitro.SelectedIndex = 1; 
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            string tenDN = txtTendangnhap.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            string nhapLai = txtNhaplaimk.Text.Trim();
            string hoTen = txtHoten.Text.Trim();
            string sdt = guna2TextBox1.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gt = cboGioitinh.SelectedItem?.ToString();
            string vaiTro = cboVaitro.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus(); return;
            }
            if (string.IsNullOrEmpty(tenDN))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus(); return;
            }
            if (string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus(); return;
            }
            if (mk != nhapLai)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaplaimk.Clear(); txtNhaplaimk.Focus(); return;
            }

         
            if (taiKhoanDB.KiemTraTrungTenDN(tenDN))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại trên hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus(); return;
            }

            
            string maNV = "NV_" + tenDN; 

           
            QLCUAHANGHOATUOI.Entity.TaiKhoan taiKhoanMoi = new QLCUAHANGHOATUOI.Entity.TaiKhoan(tenDN, mk, vaiTro, maNV);

            
            if (taiKhoanDB.Them(taiKhoanMoi))
            {
                MessageBox.Show($"Đăng ký thành công tài khoản: {tenDN} với quyền {vaiTro}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Vui lòng kiểm tra lại kết nối Database hoặc xem mã nhân viên có bị trùng không.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void lblTendangnhap_Click(object sender, EventArgs e) { }
        private void lblNhaplaimk_Click(object sender, EventArgs e) { }
        private void lblHoten_Click(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void txtVaitro_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboGioitinh_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDangky_Click(object sender, EventArgs e) { }
    }
}