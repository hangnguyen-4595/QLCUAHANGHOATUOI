using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCUAHANGHOATUOI;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            frmDangky frm = new frmDangky();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaikhoan.Text.Trim();
            string password = txtMatkhau.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                txtTaikhoan.Focus();
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtMatkhau.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MaNV, VaiTro FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maNV = reader["MaNV"] != DBNull.Value ? reader["MaNV"].ToString() : "NV001";
                                string vaiTro = reader["VaiTro"] != DBNull.Value ? reader["VaiTro"].ToString() : "Nhân viên";

                                Session.MaNV = maNV;
                                Session.TenDangNhap = username;
                                Session.VaiTro = vaiTro;

                                if (vaiTro.Equals("Quản lý", StringComparison.OrdinalIgnoreCase) || 
                                    vaiTro.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    frmManchinh frm = new frmManchinh();
                                    frm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    frmNhanvien frm = new frmNhanvien();
                                    frm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMatkhau.Clear();
                                txtMatkhau.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
