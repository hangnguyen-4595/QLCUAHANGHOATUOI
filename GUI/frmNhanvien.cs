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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            frmKhachang frm = new frmKhachang();
            frm.ShowDialog();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            frmHoadon frm = new frmHoadon();
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

        private void btnSanpham_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
