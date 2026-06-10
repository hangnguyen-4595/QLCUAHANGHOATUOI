using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmManchinh : Form
    {
        public frmManchinh()
        {
            InitializeComponent();
            dtpNgaythang.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            frmTrangchu frm = new frmTrangchu();
            frm.ShowDialog();
        }

        private void btnSanpham_Click_1(object sender, EventArgs e)
        {
            frmSanpham frm = new frmSanpham();
            frm.ShowDialog();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            frmTaikhoan frm = new frmTaikhoan();
            frm.ShowDialog();
        }


        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                this.Hide();
                frmDangnhap login = new frmDangnhap();
                login.Show();
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmQLNV frm = new frmQLNV();

            this.Hide();

            frm.ShowDialog();

            this.Show();
        }
    }
}
