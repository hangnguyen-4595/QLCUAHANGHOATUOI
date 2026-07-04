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

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            uC_Trangchu1.Visible = true;
            uC_Trangchu1.BringToFront();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            uC_Nhanvien11.Visible = true;
            uC_Nhanvien11.BringToFront();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            uC_Sanpham1.Visible = true;
            uC_Sanpham1.BringToFront();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            uC_Hoadon1.Visible = true;
            uC_Hoadon1.BringToFront();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            uC_Khachhang1.Visible = true;
            uC_Khachhang1.BringToFront();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {

        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            uC_Taikhoan1.Visible = true;
            uC_Taikhoan1.BringToFront();
        }

        private void btnDangxuat_Click_1(object sender, EventArgs e)
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

        private void uC_Khachhang1_Load(object sender, EventArgs e)
        {

        }

        private void frmManchinh_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
