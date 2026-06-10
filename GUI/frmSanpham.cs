using QLCUAHANGHOATUOI.GUI;
using QLCUAHANGHOATUOI.UC_QLSP;
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
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            dgvSanpham.AutoGenerateColumns = false;
            colMasp.DataPropertyName = "MaSP";
            colTensp.DataPropertyName = "TenSP";
            colLoai.DataPropertyName = "LoaiHoa";
            colGia.DataPropertyName = "GiaBan";
            colSoluong.DataPropertyName = "SoLuong";
            colNguongoc.DataPropertyName = "NguonGoc";
            dgvSanpham.DataSource = SanPhamManager.DanhSach;
            dgvSanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMasp.Text) || string.IsNullOrEmpty(txtTensp.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SP và Tên SP!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtGiaban.Text, out decimal gia))
            {
                MessageBox.Show("Giá bán phải là số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPhamManager.DanhSach.Add(new SanPham
            {
                MaSP = txtMasp.Text.Trim(),
                TenSP = txtTensp.Text.Trim(),
                LoaiHoa = cboLoaihoa.Text,
                GiaBan = gia,
                SoLuong = (int)nudSoluong.Value,
                NguonGoc = txtNguongoc.Text.Trim()
            });

            dgvSanpham.DataSource = null;
            dgvSanpham.DataSource = SanPhamManager.DanhSach;

            txtMasp.Clear(); txtTensp.Clear();
            txtGiaban.Clear(); txtNguongoc.Clear();
            nudSoluong.Value = 0;

            MessageBox.Show("Thêm sản phẩm thành công!");
        }

        private void btnQuaylai_Click(object sender, EventArgs e) { this.Close(); }
        private void btnSanpham_Click(object sender, EventArgs e) { }
        private void pnlTrangchu_Paint(object sender, PaintEventArgs e) { }
    }
}
