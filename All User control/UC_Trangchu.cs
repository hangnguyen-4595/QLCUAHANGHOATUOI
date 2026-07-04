using QLCUAHANGHOATUOI.Database;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class UC_Trangchu : UserControl
    {
        private readonly TrangChuDB trangChuDB = new TrangChuDB();

        public UC_Trangchu()
        {
            InitializeComponent();
        }

        private void UC_Trangchu_Load(object sender, EventArgs e)
        {
            CapNhatThongKeTrangChu();
        }

        private void CapNhatThongKeTrangChu()
        {
            decimal doanhThu = trangChuDB.LayDoanhThuHomNay();
            lblDoanhThu.Text = doanhThu.ToString("N0");

            int soDonHang = trangChuDB.LaySoDonHangHomNay();
            lblDonHang.Text = soDonHang.ToString();

            int donDangXuLy = trangChuDB.LaySoDonDangXuLy();
            lblDonDangXuLy.Text = donDangXuLy.ToString();

            VeBieuDo();
        }

        private void VeBieuDo()
        {
            DataTable dt = trangChuDB.LayXuHuongBanHangTuanNay();

            chartXuHuong.Series.Clear();
            Series series = new Series("Xu hướng")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };
            chartXuHuong.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                string thu = "Thứ " + row["Thu"].ToString();
                if (row["Thu"].ToString() == "1") thu = "CN";

                int soDon = Convert.ToInt32(row["SoDon"]);
                series.Points.AddXY(thu, soDon);
            }
        }
    }
}