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
    public partial class frmManchinh : Form
    {
        private Guna2Panel pnlContent;
        private Form activeForm = null;

        public frmManchinh()
        {
            InitializeComponent();
            dtpNgaythang.Text = DateTime.Now.ToString("dd/MM/yyyy");

            pnlContent = new Guna2Panel();
            pnlContent.Location = new System.Drawing.Point(301, 115);
            pnlContent.Size = new System.Drawing.Size(1206, 682);
            pnlContent.BackColor = System.Drawing.Color.White;
            pnlMain.Controls.Add(pnlContent);
            
            pnlMain.BackColor = System.Drawing.Color.LightPink;
            pnlMenu.BackColor = System.Drawing.Color.PaleVioletRed;
            pnlXinchao.BackColor = System.Drawing.Color.Pink;

            OpenChildForm(new frmTrangchu());
        }

        private void OpenChildForm(Form childForm)
        {
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

        private void btnSanpham_Click(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangchu());
        }

        private void btnSanpham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanpham());
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaikhoan());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLNV());
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

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoadon());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangchu());
        }
    }
}
