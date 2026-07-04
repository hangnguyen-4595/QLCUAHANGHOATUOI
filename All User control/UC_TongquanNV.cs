using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLCUAHANGHOATUOI.All_User_control
{
    public partial class UC_TongquanNV : UserControl
    {
        private List<Image> danhSachAnh = new List<Image>();
        private int indexHienTai = 0;

        public UC_TongquanNV()
        {
            InitializeComponent();
        }

        private void UC_TongquanNV_Load(object sender, EventArgs e)
        {
            danhSachAnh.Add(Properties.Resources.anh1);
            danhSachAnh.Add(Properties.Resources.anh2);
            danhSachAnh.Add(Properties.Resources.anh3);
            danhSachAnh.Add(Properties.Resources.anh4);
            danhSachAnh.Add(Properties.Resources.anh5);
            danhSachAnh.Add(Properties.Resources.anh6);
            danhSachAnh.Add(Properties.Resources.anh7);
            danhSachAnh.Add(Properties.Resources.anh8);
            danhSachAnh.Add(Properties.Resources.anh9);
            danhSachAnh.Add(Properties.Resources.anh10);
            if (danhSachAnh.Count > 0)
            {
                pictureBox1.Image = danhSachAnh[indexHienTai];
            }

            timer1.Interval = 3000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (danhSachAnh.Count == 0) return;

            indexHienTai++;

            if (indexHienTai >= danhSachAnh.Count)
            {
                indexHienTai = 0;
            }

            pictureBox1.Image = danhSachAnh[indexHienTai];
        }
    }
}