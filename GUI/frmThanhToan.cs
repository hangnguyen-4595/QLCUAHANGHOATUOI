using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLCUAHANGHOATUOI;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmThanhToan : Form
    {
        private Guna2Panel pnlMain;
        private Label lblTitle;
        private Label lblSanPham;
        private Guna2ComboBox cboSanPham;
        private Label lblSoLuong;
        private Guna2NumericUpDown numSoLuong;
        private Guna2Button btnThem;
        private Guna2DataGridView dgvGioHang;
        private Label lblSdtKH;
        private Guna2TextBox txtSdtKH;
        private Label lblKhachHang;
        private Guna2TextBox txtKhachHang;
        private Label lblTongTienText;
        private Label lblTongTien;
        private Guna2Button btnThanhToan;

        private DataTable dtGioHang;

        public frmThanhToan()
        {
            InitializeComponent();
            SetupUI();
            LoadSanPham();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(1206, 682);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "frmThanhToan";
            this.ResumeLayout(false);
        }

        private void SetupUI()
        {
            pnlMain = new Guna2Panel() { Dock = DockStyle.Fill, BackColor = Color.White };
            this.Controls.Add(pnlMain);

            lblTitle = new Label() { Text = "🌷 QUẢN LÝ THANH TOÁN", Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = Color.DeepPink, Location = new Point(30, 25), AutoSize = true };
            pnlMain.Controls.Add(lblTitle);

            lblSdtKH = new Label() { Text = "Số Điện Thoại Khách:", Location = new Point(660, 15), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.DimGray };
            pnlMain.Controls.Add(lblSdtKH);
            txtSdtKH = new Guna2TextBox() { Location = new Point(660, 40), Size = new Size(240, 36), BorderRadius = 6 };
            txtSdtKH.Leave += TxtSdtKH_Leave;
            pnlMain.Controls.Add(txtSdtKH);

            lblKhachHang = new Label() { Text = "Tên Khách Hàng:", Location = new Point(920, 15), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.DimGray };
            pnlMain.Controls.Add(lblKhachHang);
            txtKhachHang = new Guna2TextBox() { Location = new Point(920, 40), Size = new Size(250, 36), BorderRadius = 6 };
            pnlMain.Controls.Add(txtKhachHang);

            lblSanPham = new Label() { Text = "Chọn Sản Phẩm Hoa:", Location = new Point(30, 90), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.DimGray };
            pnlMain.Controls.Add(lblSanPham);
            cboSanPham = new Guna2ComboBox() { Location = new Point(30, 115), Size = new Size(300, 36), DisplayMember = "TenSP", ValueMember = "MaSP", BorderRadius = 6 };
            pnlMain.Controls.Add(cboSanPham);

            lblSoLuong = new Label() { Text = "Số lượng:", Location = new Point(350, 90), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.DimGray };
            pnlMain.Controls.Add(lblSoLuong);
            numSoLuong = new Guna2NumericUpDown() { Location = new Point(350, 115), Size = new Size(100, 36), Minimum = 1, Value = 1, BorderRadius = 6 };
            pnlMain.Controls.Add(numSoLuong);

            btnThem = new Guna2Button() { Text = "Thêm vào giỏ", Location = new Point(480, 115), Size = new Size(150, 36), FillColor = Color.HotPink, BorderRadius = 6, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnThem.Click += BtnThem_Click;
            pnlMain.Controls.Add(btnThem);

            dgvGioHang = new Guna2DataGridView() 
            { 
                Location = new Point(30, 170), 
                Size = new Size(1140, 390), 
                ReadOnly = true, 
                AllowUserToAddRows = false, 
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ThemeStyle = { GridColor = Color.LightPink }
            };
            pnlMain.Controls.Add(dgvGioHang);

            lblTongTienText = new Label() { Text = "Tổng Tiền:", Font = new Font("Segoe UI", 14, FontStyle.Bold), Location = new Point(850, 580), AutoSize = true };
            pnlMain.Controls.Add(lblTongTienText);

            lblTongTien = new Label() { Text = "0 VNĐ", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.Red, Location = new Point(960, 580), AutoSize = true };
            pnlMain.Controls.Add(lblTongTien);

            btnThanhToan = new Guna2Button() 
            { 
                Text = "Thanh toán & In hóa đơn", 
                Location = new Point(930, 620), 
                Size = new Size(240, 45), 
                FillColor = Color.MediumSeaGreen, 
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BorderRadius = 8
            };
            btnThanhToan.Click += BtnThanhToan_Click;
            pnlMain.Controls.Add(btnThanhToan);

            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaSP", typeof(string));
            dtGioHang.Columns.Add("TenSP", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal));
            dgvGioHang.DataSource = dtGioHang;
        }

        private void LoadSanPham()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT MaSP, TenSP, GiaBan FROM SanPham WHERE TrangThai = N'Còn hàng'";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboSanPham.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void TxtSdtKH_Leave(object sender, EventArgs e)
        {
            string sdt = txtSdtKH.Text.Trim();
            if (string.IsNullOrEmpty(sdt)) return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT HoTen FROM KhachHang WHERE SoDienThoai = @sdt";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sdt", sdt);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtKhachHang.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm khách hàng: " + ex.Message);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null) return;
            string maSP = cboSanPham.SelectedValue.ToString();
            string tenSP = cboSanPham.Text;
            int soLuong = (int)numSoLuong.Value;
            decimal donGia = 0;

            DataRowView rowView = cboSanPham.SelectedItem as DataRowView;
            if (rowView != null)
            {
                donGia = Convert.ToDecimal(rowView["GiaBan"]);
            }

            bool found = false;
            foreach (DataRow row in dtGioHang.Rows)
            {
                if (row["MaSP"].ToString() == maSP)
                {
                    row["SoLuong"] = Convert.ToInt32(row["SoLuong"]) + soLuong;
                    row["ThanhTien"] = Convert.ToInt32(row["SoLuong"]) * donGia;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                dtGioHang.Rows.Add(maSP, tenSP, soLuong, donGia, soLuong * donGia);
            }

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                tong += Convert.ToDecimal(row["ThanhTien"]);
            }
            lblTongTien.Text = tong.ToString("N0") + " VNĐ";
            lblTongTien.Tag = tong;
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            string sdt = txtSdtKH.Text.Trim();
            string khachHang = txtKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(sdt) && string.IsNullOrEmpty(khachHang))
            {
                khachHang = "Khách vãng lai";
            }
            else if (!string.IsNullOrEmpty(sdt) && string.IsNullOrEmpty(khachHang))
            {
                khachHang = "Khách vãng lai (" + sdt + ")";
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        string maKH = null;

                        if (!string.IsNullOrEmpty(sdt))
                        {
                            string selectQuery = "SELECT MaKH FROM KhachHang WHERE SoDienThoai = @sdt";
                            using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn, trans))
                            {
                                cmdSelect.Parameters.AddWithValue("@sdt", sdt);
                                object res = cmdSelect.ExecuteScalar();
                                if (res != null)
                                {
                                    maKH = res.ToString();
                                }
                            }

                            if (maKH == null)
                            {
                                maKH = "KH" + DateTime.Now.ToString("yyyyMMddHHmmss");
                                string insertKH = "INSERT INTO KhachHang (MaKH, HoTen, SoDienThoai, DiaChi) VALUES (@MaKH, @HoTen, @SoDienThoai, @DiaChi)";
                                using (SqlCommand cmdInsert = new SqlCommand(insertKH, conn, trans))
                                {
                                    cmdInsert.Parameters.AddWithValue("@MaKH", maKH);
                                    cmdInsert.Parameters.AddWithValue("@HoTen", khachHang);
                                    cmdInsert.Parameters.AddWithValue("@SoDienThoai", sdt);
                                    cmdInsert.Parameters.AddWithValue("@DiaChi", "Chưa cập nhật");
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }

                        string maHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        decimal tongTien = Convert.ToDecimal(lblTongTien.Tag);

                        string sqlHD = "INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayLap, TongTien) VALUES (@MaHD, @MaKH, @MaNV, GETDATE(), @TongTien)";
                        using (SqlCommand cmdHD = new SqlCommand(sqlHD, conn, trans))
                        {
                            cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                            cmdHD.Parameters.AddWithValue("@MaKH", (object)maKH ?? DBNull.Value);
                            cmdHD.Parameters.AddWithValue("@MaNV", (object)Session.MaNV ?? DBNull.Value);
                            cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                            cmdHD.ExecuteNonQuery();
                        }

                        foreach (DataRow row in dtGioHang.Rows)
                        {
                            string sqlCT = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                            using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans))
                            {
                                cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                                cmdCT.Parameters.AddWithValue("@MaSP", row["MaSP"]);
                                cmdCT.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                                cmdCT.Parameters.AddWithValue("@DonGia", row["DonGia"]);
                                cmdCT.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();

                        string tenCashier = Session.TenDangNhap;
                        try
                        {
                            string sqlNV = "SELECT HoTen FROM NhanVien WHERE MaNV = @MaNV";
                            using (SqlCommand cmdNV = new SqlCommand(sqlNV, conn))
                            {
                                cmdNV.Parameters.AddWithValue("@MaNV", Session.MaNV);
                                object res = cmdNV.ExecuteScalar();
                                if (res != null) tenCashier = res.ToString();
                            }
                        }
                        catch { }

                        frmInHoaDon printFrm = new frmInHoaDon(maHD, khachHang, sdt, dtGioHang.Copy(), tongTien, tenCashier);
                        printFrm.ShowDialog();

                        dtGioHang.Clear();
                        TinhTongTien();
                        txtSdtKH.Clear();
                        txtKhachHang.Clear();
                        numSoLuong.Value = 1;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
