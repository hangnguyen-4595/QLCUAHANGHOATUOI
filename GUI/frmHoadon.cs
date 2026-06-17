using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QLCUAHANGHOATUOI;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
            SetupLayout();
            LoadDanhSachHoaDon();
            
            dgvDShoadon.CellClick += DgvDShoadon_CellClick;
        }

        private void SetupLayout()
        {
            pnlMenu.Visible = false;
            pnlXinchao.Visible = false;
            this.BackColor = Color.White;
            pnlMain.BackColor = Color.White;
            txtMahd.ReadOnly = true;
            txtTongtien.ReadOnly = true;
            
            lblThanhtoanhd.Text = "CHI TIẾT ĐƠN HÀNG";
            btnThanhtoan.Text = "Xóa đơn hàng";
            btnThanhtoan.FillColor = Color.Crimson;
            lblCTHoadon.Location = new Point(30, 20);
            dgvChiTietHD.Location = new Point(30, 70);
            dgvChiTietHD.Size = new Size(750, 320);

            lblDshoadon.Location = new Point(30, 410);
            dgvDShoadon.Location = new Point(30, 460);
            dgvDShoadon.Size = new Size(750, 280);

            lblThanhtoanhd.Location = new Point(820, 20);
            
            lblMahd.Location = new Point(820, 80);
            txtMahd.Location = new Point(820, 105);
            txtMahd.Size = new Size(320, 36);

            lblChonkh.Text = "Khách hàng:";
            lblChonkh.Location = new Point(820, 160);
            cboKhachang.Location = new Point(820, 185);
            cboKhachang.Size = new Size(320, 36);
            cboKhachang.Enabled = false;

            lblNgaylap.Location = new Point(820, 240);
            dtpNgaylap.Location = new Point(820, 265);
            dtpNgaylap.Size = new Size(320, 36);
            dtpNgaylap.Enabled = false;

            lblTongtien.Location = new Point(820, 320);
            txtTongtien.Location = new Point(820, 345);
            txtTongtien.Size = new Size(320, 36);

            btnThanhtoan.Location = new Point(820, 410);
            btnThanhtoan.Size = new Size(320, 40);
        }

        private void LoadDanhSachHoaDon()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            hd.MaHD, 
                            ISNULL(kh.HoTen, N'Khách vãng lai') AS TenKH, 
                            hd.NgayLap, 
                            hd.TongTien 
                        FROM HoaDon hd 
                        LEFT JOIN KhachHang kh ON hd.MaKH = kh.MaKH
                        ORDER BY hd.NgayLap DESC";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        dgvDShoadon.AutoGenerateColumns = false;
                        colMahd.DataPropertyName = "MaHD";
                        colKhachhang.DataPropertyName = "TenKH";
                        colNgaylap.DataPropertyName = "NgayLap";
                        colTongtien.DataPropertyName = "TongTien";
                        
                        dgvDShoadon.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvDShoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDShoadon.Rows[e.RowIndex];
                string maHD = row.Cells[0].Value?.ToString();
                
                if (dgvDShoadon.Columns.Contains("colMahd"))
                {
                    maHD = row.Cells["colMahd"].Value?.ToString();
                }

                txtMahd.Text = maHD;
                
                object valTongTien = null;
                if (dgvDShoadon.Columns.Contains("colTongtien"))
                {
                    valTongTien = row.Cells["colTongtien"].Value;
                }
                if (valTongTien != null && decimal.TryParse(valTongTien.ToString(), out decimal tt))
                {
                    txtTongtien.Text = tt.ToString("N0") + " VNĐ";
                }
                else
                {
                    txtTongtien.Text = "0 VNĐ";
                }

                if (dgvDShoadon.Columns.Contains("colKhachhang"))
                {
                    cboKhachang.Text = row.Cells["colKhachhang"].Value?.ToString();
                }
                
                if (dgvDShoadon.Columns.Contains("colNgaylap") && row.Cells["colNgaylap"].Value != null)
                {
                    dtpNgaylap.Value = Convert.ToDateTime(row.Cells["colNgaylap"].Value);
                }

                LoadChiTietHoaDon(maHD);
            }
        }

        private void LoadChiTietHoaDon(string maHD)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            ct.MaSP, 
                            sp.TenSP, 
                            ct.SoLuong, 
                            ct.DonGia, 
                            (ct.SoLuong * ct.DonGia) AS ThanhTien 
                        FROM ChiTietHoaDon ct 
                        JOIN SanPham sp ON ct.MaSP = sp.MaSP 
                        WHERE ct.MaHD = @MaHD";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvChiTietHD.AutoGenerateColumns = false;
                            colMaSP.DataPropertyName = "MaSP";
                            colTenSP.DataPropertyName = "TenSP";
                            ColSoLuong.DataPropertyName = "SoLuong";
                            colDonGia.DataPropertyName = "DonGia";
                            colThanhtien.DataPropertyName = "ThanhTien";

                            dgvChiTietHD.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMahd.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        string deleteDetails = "DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD";
                        using (SqlCommand cmd = new SqlCommand(deleteDetails, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaHD", txtMahd.Text);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteInvoice = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
                        using (SqlCommand cmd = new SqlCommand(deleteInvoice, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@MaHD", txtMahd.Text);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        txtMahd.Clear();
                        txtTongtien.Clear();
                        dgvChiTietHD.DataSource = null;
                        
                        LoadDanhSachHoaDon();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e) { this.Close(); }
        private void lblHoadon_Click(object sender, EventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
        private void lblNgaylap_Click(object sender, EventArgs e) { }
        private void lblTongtien_Click(object sender, EventArgs e) { }
        private void lblThanhtoanhd_Click(object sender, EventArgs e) { }
    }
}