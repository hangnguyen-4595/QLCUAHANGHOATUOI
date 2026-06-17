using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmNhanvien : Form
    {
        private Guna2Panel pnlContent;
        private Form activeForm = null;

        public frmNhanvien()
        {
            InitializeComponent();
            
            btnThongke.Visible = false;
            btnHoadon.Text = "Thanh toán";

            pnlContent = new Guna2Panel();
            pnlContent.Location = new System.Drawing.Point(301, 115);
            pnlContent.Size = new System.Drawing.Size(1206, 682);
            pnlContent.BackColor = System.Drawing.Color.White;
            pnlMain.Controls.Add(pnlContent);

            pnlMain.BackColor = System.Drawing.Color.LightPink;
            pnlMenu.BackColor = System.Drawing.Color.PaleVioletRed;
            pnlXinchao.BackColor = System.Drawing.Color.Pink;

            OpenChildForm(new frmThanhToan());
        }

        private void OpenChildForm(Form childForm)
        {
            pnlTongsanpham.Visible = false;
            pnlKhachhang.Visible = false;
            pnlDoanhthu.Visible = false;
            pnlAnhloichao.Visible = false;

            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachang());
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThanhToan());
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

        private void btnSanpham_Click_1(object sender, EventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
    }
}
