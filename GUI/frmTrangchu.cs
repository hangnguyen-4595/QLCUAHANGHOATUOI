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
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }

        private void lblDoanhthu_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            pnlMenu.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMenu.Controls.Add(childForm);
            childForm.Show();
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangchu());
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {         
            this.Close();
        }
    }
}
