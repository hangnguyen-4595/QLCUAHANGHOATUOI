using QLCUAHANGHOATUOI.GUI;
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
    public partial class frmHoadon : Form
    {
        string connStr =
        @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\DELL\Documents\dbCuaHangHoaTuoi.mdf;
        Integrated Security=True;
        Connect Timeout=30;";
        private static int soHD = 1; 

        public frmHoadon()
        {
            InitializeComponent();
            LoadKhachHang();
            LoadSanPhamVaoChiTiet(); 
            dtpNgaylap.Value = DateTime.Now;
            txtMahd.Text = $"HD{soHD:D3}";
        }

        private void LoadKhachHang()
        {
            cboKhachang.Items.Clear();
            foreach (var kh in KhachHangManager.DanhSach)
                cboKhachang.Items.Add(kh);
            if (cboKhachang.Items.Count > 0)
                cboKhachang.SelectedIndex = 0;
        }

        private void LoadSanPhamVaoChiTiet()
        {
            dgvChiTietHD.Rows.Clear();
            foreach (var sp in SanPhamManager.DanhSach)
            {
                int soLuong = 1;
                decimal thanhTien = sp.GiaBan * soLuong;
                dgvChiTietHD.Rows.Add(
                    sp.MaSP,
                    sp.TenSP,
                    soLuong,
                    sp.GiaBan.ToString("#,##0"),
                    thanhTien.ToString("#,##0")
                );
            }
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvChiTietHD.Rows)
            {
                if (row.Cells[colThanhtien.Index].Value != null)
                {
                    string val = row.Cells[colThanhtien.Index].Value
                        .ToString().Replace(",", "").Replace(" đ", "").Trim();
                    if (decimal.TryParse(val, out decimal tt))
                        tong += tt;
                }
            }
            txtTongtien.Text = tong.ToString("#,##0") + " đ";
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMahd.Text) || cboKhachang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvDShoadon.Rows.Add(
                txtMahd.Text,
                cboKhachang.Text,
                dtpNgaylap.Value.ToString("dd/MM/yyyy"),
                txtTongtien.Text
            );
            MessageBox.Show($"Thanh toán thành công!\nMã HĐ: {txtMahd.Text}", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            soHD++;
            txtMahd.Text = $"HD{soHD:D3}";
            dgvChiTietHD.Rows.Clear();
            txtTongtien.Text = "0 đ";
        }

        private void btnQuaylai_Click(object sender, EventArgs e) { this.Close(); }
        private void lblHoadon_Click(object sender, EventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }

        private void lblNgaylap_Click(object sender, EventArgs e)
        {

        }

        private void lblTongtien_Click(object sender, EventArgs e)
        {

        }

        private void lblThanhtoanhd_Click(object sender, EventArgs e)
        {

        }
    }
}