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


        private void pnlXinchao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

    }
}
