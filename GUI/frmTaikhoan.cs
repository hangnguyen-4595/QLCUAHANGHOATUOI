using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QLCUAHANGHOATUOI;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmTaikhoan : Form
    {
        private Label lblQuanLyTaikhoan;
        private Label lblTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label lblMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label lblVaiTro;
        private Guna.UI2.WinForms.Guna2ComboBox cboRole;
        private Label lblNhanVien;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVien;

        private Guna.UI2.WinForms.Guna2Button btnThemTK;
        private Guna.UI2.WinForms.Guna2Button btnSuaTK;
        private Guna.UI2.WinForms.Guna2Button btnXoaTK;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiTK;

        public frmTaikhoan()
        {
            InitializeComponent();
            HideOldControls();
            SetupAccountCRUDControls();
            LoadEmployees();
            LoadDanhSach();

            dgvTaikhoan.CellClick += DgvTaikhoan_CellClick;
        }

        private void HideOldControls()
        {
            txtMaTK.Visible = false;
            txtTenTK.Visible = false;
            txtSdt.Visible = false;
            txtDiachi.Visible = false;
            cboGioitinh.Visible = false;
            dtpNgaysinh.Visible = false;
            btnThemnv.Visible = false;
            lblGioitinh.Visible = false;
            lblNgaysinh.Visible = false;
            lblThemtk.Visible = false;
            
            pnlMenu.Visible = false;
            pnlXinchao.Visible = false;
            this.BackColor = Color.White;
            pnlMain.BackColor = Color.White;
            
            lblTaikhoan.Location = new Point(343, 20);
            dgvTaikhoan.Location = new Point(30, 80);
            dgvTaikhoan.Size = new Size(780, 580);
        }

        private void SetupAccountCRUDControls()
        {
            lblQuanLyTaikhoan = new Label()
            {
                Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DeepPink,
                Location = new Point(840, 80),
                AutoSize = true
            };
            pnlMain.Controls.Add(lblQuanLyTaikhoan);

            lblTenDangNhap = new Label() { Text = "Tên đăng nhập:", Location = new Point(840, 130), AutoSize = true, Font = new Font("Segoe UI", 9) };
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox() { Location = new Point(840, 155), Size = new Size(320, 36), BorderRadius = 6 };
            pnlMain.Controls.Add(lblTenDangNhap);
            pnlMain.Controls.Add(txtUsername);

            lblMatKhau = new Label() { Text = "Mật khẩu:", Location = new Point(840, 210), AutoSize = true, Font = new Font("Segoe UI", 9) };
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox() { Location = new Point(840, 235), Size = new Size(320, 36), BorderRadius = 6, PasswordChar = '\0' };
            pnlMain.Controls.Add(lblMatKhau);
            pnlMain.Controls.Add(txtPassword);
            lblVaiTro = new Label() { Text = "Vai trò:", Location = new Point(840, 290), AutoSize = true, Font = new Font("Segoe UI", 9) };
            cboRole = new Guna.UI2.WinForms.Guna2ComboBox() { Location = new Point(840, 315), Size = new Size(320, 36), BorderRadius = 6 };
            cboRole.Items.AddRange(new object[] { "Admin", "NhanVien" });
            pnlMain.Controls.Add(lblVaiTro);
            pnlMain.Controls.Add(cboRole);

            lblNhanVien = new Label() { Text = "Nhân viên liên kết:", Location = new Point(840, 370), AutoSize = true, Font = new Font("Segoe UI", 9) };
            cboNhanVien = new Guna.UI2.WinForms.Guna2ComboBox() { Location = new Point(840, 395), Size = new Size(320, 36), BorderRadius = 6 };
            pnlMain.Controls.Add(lblNhanVien);
            pnlMain.Controls.Add(cboNhanVien);

            btnThemTK = new Guna.UI2.WinForms.Guna2Button() { Text = "Thêm", Location = new Point(840, 460), Size = new Size(72, 38), FillColor = Color.HotPink, BorderRadius = 6, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            btnSuaTK = new Guna.UI2.WinForms.Guna2Button() { Text = "Sửa", Location = new Point(920, 460), Size = new Size(72, 38), FillColor = Color.MediumSeaGreen, BorderRadius = 6, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            btnXoaTK = new Guna.UI2.WinForms.Guna2Button() { Text = "Xóa", Location = new Point(1000, 460), Size = new Size(72, 38), FillColor = Color.Crimson, BorderRadius = 6, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            btnLamMoiTK = new Guna.UI2.WinForms.Guna2Button() { Text = "Mới", Location = new Point(1080, 460), Size = new Size(80, 38), FillColor = Color.SlateGray, BorderRadius = 6, Font = new Font("Segoe UI", 9, FontStyle.Bold) };

            btnThemTK.Click += BtnThemTK_Click;
            btnSuaTK.Click += BtnSuaTK_Click;
            btnXoaTK.Click += BtnXoaTK_Click;
            btnLamMoiTK.Click += BtnLamMoiTK_Click;

            pnlMain.Controls.Add(btnThemTK);
            pnlMain.Controls.Add(btnSuaTK);
            pnlMain.Controls.Add(btnXoaTK);
            pnlMain.Controls.Add(btnLamMoiTK);
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MaNV, HoTen FROM NhanVien";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboNhanVien.DataSource = dt;
                        cboNhanVien.DisplayMember = "HoTen";
                        cboNhanVien.ValueMember = "MaNV";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void LoadDanhSach()
        {
            colTenDN.DataPropertyName = "TenDangNhap";
            colMatkhau.DataPropertyName = "MatKhau";
            colHoten.DataPropertyName = "HoTen";
            colVaitro.DataPropertyName = "VaiTro";
            colGioitinh.DataPropertyName = "GioiTinh";
            colSdt.DataPropertyName = "SoDienThoai";
            
            colMatkhau.Visible = true;

            dgvTaikhoan.AutoGenerateColumns = false;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT tk.TenDangNhap, tk.MatKhau, nv.HoTen, tk.VaiTro, nv.GioiTinh, nv.SoDienThoai 
                        FROM TaiKhoan tk 
                        LEFT JOIN NhanVien nv ON tk.MaNV = nv.MaNV";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTaikhoan.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu tài khoản: " + ex.Message);
            }

            dgvTaikhoan.ReadOnly = true;
            dgvTaikhoan.AllowUserToAddRows = false;
            dgvTaikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaikhoan.RowHeadersVisible = false;
        }

        private void DgvTaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaikhoan.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[0].Value?.ToString();
                txtPassword.Text = row.Cells[1].Value?.ToString();
                cboRole.Text = row.Cells[3].Value?.ToString();
                cboNhanVien.Text = row.Cells[2].Value?.ToString();

                txtUsername.ReadOnly = true;
            }
        }

        private void BtnThemTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên liên kết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string maTK = "TK" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string query = "INSERT INTO TaiKhoan (MaTK, MaNV, TenDangNhap, MatKhau, VaiTro) VALUES (@MaTK, @MaNV, @Username, @Password, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTK", maTK);
                        cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem?.ToString() ?? "NhanVien");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE TaiKhoan SET MatKhau = @Password, VaiTro = @Role, MaNV = @MaNV WHERE TenDangNhap = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem?.ToString() ?? "NhanVien");
                        cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue?.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM TaiKhoan WHERE TenDangNhap = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLamMoiTK_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboRole.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            txtUsername.ReadOnly = false;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTaikhoan_Click(object sender, EventArgs e) { }
        private void lblThemnv_Click(object sender, EventArgs e) { }
    }
}
