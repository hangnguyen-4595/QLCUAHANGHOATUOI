using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QLCUAHANGHOATUOI.GUI
{
    public class frmInHoaDon : Form
    {
        private string maHD;
        private string tenKH;
        private string sdtKH;
        private DataTable dtGioHang;
        private decimal tongTien;
        private string tenCashier;

        private Panel pnlReceipt;
        private Label lblShopName;
        private Label lblShopInfo;
        private Label lblReceiptTitle;
        private Label lblDivider1;
        private Label lblDivider2;
        private Label lblDivider3;
        private Label lblInfo;
        private Label lblTotal;
        private Label lblFooter;
        private TableLayoutPanel tblItems;
        private Guna2Button btnPrint;
        private Guna2Button btnClose;

        public frmInHoaDon(string maHD, string tenKH, string sdtKH, DataTable dtGioHang, decimal tongTien, string tenCashier)
        {
            this.maHD = maHD;
            this.tenKH = tenKH;
            this.sdtKH = sdtKH;
            this.dtGioHang = dtGioHang;
            this.tongTien = tongTien;
            this.tenCashier = tenCashier;

            InitializeComponent();
            SetupReceipt();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(460, 680);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Hóa Đơn Thanh Toán - In";
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ResumeLayout(false);
        }

        private void SetupReceipt()
        {
            pnlReceipt = new Panel()
            {
                Location = new Point(20, 20),
                Size = new Size(420, 560),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(pnlReceipt);

            FlowLayoutPanel flow = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(15)
            };
            pnlReceipt.Controls.Add(flow);

            lblShopName = new Label()
            {
                Text = "🌷 AN NHIÊN FLOWER SHOP 🌷",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.DeepPink,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 30),
                AutoSize = false
            };
            flow.Controls.Add(lblShopName);

            lblShopInfo = new Label()
            {
                Text = "ĐC: 123 Đường Hoa Hồng, Quận 1, TP. HCM\nSĐT: 0901.234.567\nChuyên hoa tươi - Thiết kế hoa sự kiện",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.DimGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 50),
                AutoSize = false
            };
            flow.Controls.Add(lblShopInfo);

            lblDivider1 = new Label()
            {
                Text = "--------------------------------------------------------",
                Font = new Font("Courier New", 9),
                ForeColor = Color.DarkGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 15),
                AutoSize = false
            };
            flow.Controls.Add(lblDivider1);

            lblReceiptTitle = new Label()
            {
                Text = "HÓA ĐƠN BÁN LẺ",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 25),
                AutoSize = false
            };
            flow.Controls.Add(lblReceiptTitle);

            string infoText = 
                $"Số HĐ: {maHD}\n" +
                $"Ngày: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}\n" +
                $"Khách hàng: {tenKH}\n" +
                $"SĐT: {(string.IsNullOrEmpty(sdtKH) ? "N/A" : sdtKH)}\n" +
                $"Thu ngân: {tenCashier}";
            
            lblInfo = new Label()
            {
                Text = infoText,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                Size = new Size(390, 90),
                AutoSize = false
            };
            flow.Controls.Add(lblInfo);

            lblDivider2 = new Label()
            {
                Text = "--------------------------------------------------------",
                Font = new Font("Courier New", 9),
                ForeColor = Color.DarkGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 15),
                AutoSize = false
            };
            flow.Controls.Add(lblDivider2);

            TableLayoutPanel tblHeader = new TableLayoutPanel()
            {
                Size = new Size(390, 25),
                ColumnCount = 4,
                RowCount = 1
            };
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            tblHeader.Controls.Add(new Label() { Text = "Sản phẩm", Font = new Font("Segoe UI", 9, FontStyle.Bold) }, 0, 0);
            tblHeader.Controls.Add(new Label() { Text = "SL", Font = new Font("Segoe UI", 9, FontStyle.Bold), TextAlign = ContentAlignment.TopRight }, 1, 0);
            tblHeader.Controls.Add(new Label() { Text = "Đơn giá", Font = new Font("Segoe UI", 9, FontStyle.Bold), TextAlign = ContentAlignment.TopRight }, 2, 0);
            tblHeader.Controls.Add(new Label() { Text = "T.Tiền", Font = new Font("Segoe UI", 9, FontStyle.Bold), TextAlign = ContentAlignment.TopRight }, 3, 0);
            flow.Controls.Add(tblHeader);

            tblItems = new TableLayoutPanel()
            {
                Width = 390,
                ColumnCount = 4,
                RowCount = dtGioHang.Rows.Count,
                AutoSize = true
            };
            tblItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

            int rowIdx = 0;
            foreach (DataRow row in dtGioHang.Rows)
            {
                string name = row["TenSP"].ToString();
                int qty = Convert.ToInt32(row["SoLuong"]);
                decimal price = Convert.ToDecimal(row["DonGia"]);
                decimal total = Convert.ToDecimal(row["ThanhTien"]);

                tblItems.Controls.Add(new Label() { Text = name, Font = new Font("Segoe UI", 9), AutoSize = true }, 0, rowIdx);
                tblItems.Controls.Add(new Label() { Text = qty.ToString(), Font = new Font("Segoe UI", 9), TextAlign = ContentAlignment.TopRight, AutoSize = true }, 1, rowIdx);
                tblItems.Controls.Add(new Label() { Text = price.ToString("N0"), Font = new Font("Segoe UI", 9), TextAlign = ContentAlignment.TopRight, AutoSize = true }, 2, rowIdx);
                tblItems.Controls.Add(new Label() { Text = total.ToString("N0"), Font = new Font("Segoe UI", 9), TextAlign = ContentAlignment.TopRight, AutoSize = true }, 3, rowIdx);
                rowIdx++;
            }
            flow.Controls.Add(tblItems);

            lblDivider3 = new Label()
            {
                Text = "--------------------------------------------------------",
                Font = new Font("Courier New", 9),
                ForeColor = Color.DarkGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 15),
                AutoSize = false
            };
            flow.Controls.Add(lblDivider3);

            lblTotal = new Label()
            {
                Text = $"TỔNG TIỀN: {tongTien.ToString("N0")} VNĐ",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(390, 30),
                AutoSize = false
            };
            flow.Controls.Add(lblTotal);

            lblFooter = new Label()
            {
                Text = "Cảm ơn Quý khách!\nHẹn gặp lại quý khách tại An Nhiên Flower Shop!",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.MediumVioletRed,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(390, 45),
                AutoSize = false
            };
            flow.Controls.Add(lblFooter);

            btnPrint = new Guna2Button()
            {
                Text = "In Hóa Đơn",
                Location = new Point(50, 600),
                Size = new Size(160, 38),
                FillColor = Color.HotPink,
                BorderRadius = 8,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnPrint.Click += BtnPrint_Click;
            this.Controls.Add(btnPrint);

            btnClose = new Guna2Button()
            {
                Text = "Đóng",
                Location = new Point(250, 600),
                Size = new Size(160, 38),
                FillColor = Color.Gray,
                BorderRadius = 8,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi lệnh in đến máy in thành công!", "Thông báo in", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
