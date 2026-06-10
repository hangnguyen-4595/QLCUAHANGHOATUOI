using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmManchinh frm = new frmManchinh();
                frm.Show();
                this.Hide();
            }
            else if (username == "admin1" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmNhanvien frm = new frmNhanvien();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                txtMatkhau.Clear();
                txtMatkhau.Focus();
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
