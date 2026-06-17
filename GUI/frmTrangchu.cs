using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QLCUAHANGHOATUOI;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmTrangchu : Form
    {
        private void btnTrangchu_Click(object sender, EventArgs e) { }

        public frmTrangchu()
        {
            InitializeComponent();
            SetupLayout();
            LoadStatistics();
        }

        private void SetupLayout()
        {
            pnlMenu.Visible = false;
            pnlXinchao.Visible = false;
            this.BackColor = Color.White;
            pnlTrangchu.BackColor = Color.White;

            pnlTongsanpham.Location = new Point(20, 20);
            guna2Panel1.Location = new Point(310, 20);
            guna2Panel3.Location = new Point(600, 20);
            guna2Panel5.Location = new Point(890, 20);
            pnlAnhloichao.Location = new Point(20, 220);
            pnlAnhloichao.Size = new Size(1140, 400);
        }

        private void LoadStatistics()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string queryProducts = "SELECT ISNULL(SUM(SoLuong), 0) FROM SanPham";
                    using (SqlCommand cmd = new SqlCommand(queryProducts, conn))
                    {
                        txtSosp.Text = cmd.ExecuteScalar().ToString();
                    }

                    string queryEmployees = "SELECT COUNT(*) FROM NhanVien";
                    using (SqlCommand cmd = new SqlCommand(queryEmployees, conn))
                    {
                        txtSonv.Text = cmd.ExecuteScalar().ToString();
                    }

                    string queryCustomers = "SELECT COUNT(*) FROM KhachHang";
                    using (SqlCommand cmd = new SqlCommand(queryCustomers, conn))
                    {
                        txtSokh.Text = cmd.ExecuteScalar().ToString();
                    }

                    string queryRevenue = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(queryRevenue, conn))
                    {
                        decimal revenue = Convert.ToDecimal(cmd.ExecuteScalar());
                        txtSodoanhthu.Text = revenue.ToString("N0") + "đ";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading stats: " + ex.Message);
            }
        }

        private void lblDoanhthu_Click(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {         
            this.Close();
        }
    }
}
