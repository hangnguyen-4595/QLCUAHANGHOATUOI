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
    public partial class frmTaikhoan : Form
    {
        public frmTaikhoan()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void lblTaikhoan_Click(object sender, EventArgs e)
        {

        }
        private void LoadDanhSach()
        {
            colTenDN.DataPropertyName = "TenDangNhap";
            colHoten.DataPropertyName = "HoTen";
            colVaitro.DataPropertyName = "VaiTro";
            colGioitinh.DataPropertyName = "GioiTinh";
            colSdt.DataPropertyName = "SoDT";
            colMatkhau.Visible = false; // ẩn mật khẩu
            // Tắt auto generate để không sinh cột thừa
            dgvTaikhoan.AutoGenerateColumns = false;
            //  dữ liệu thẳng vào List
            dgvTaikhoan.DataSource = TaiKhoanManager.DanhSach;
            // Định dạng
            dgvTaikhoan.ReadOnly = true;
            dgvTaikhoan.AllowUserToAddRows = false;
            dgvTaikhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaikhoan.RowHeadersVisible = false;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblThemnv_Click(object sender, EventArgs e)
        {

        }
    }
}
