using QLCUAHANGHOATUOI.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class UC_Nhanvien : UserControl
    {
        private readonly NhanVienDB nhanVienDB = new NhanVienDB();

        private string maNVDuocChon = "";
        private string tenNVDuocChon = "";
        private string chucVuDuocChon = "";
        private string sdtDuocChon = "";
        private string gioiTinhDuocChon = "";
        private DateTime ngaySinhDuocChon = DateTime.Now;

        public UC_Nhanvien()
        {
            InitializeComponent();
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            var danhSachNV = nhanVienDB.LayDanhSach();
            dgvNhanvien.DataSource = danhSachNV;
            if (danhSachNV is System.Data.DataTable dt)
            {
                
                int tongSoNV = dt.Rows.Count;
                lblSonv.Text = tongSoNV.ToString("D2"); 

                int dangLamViec = 0;
                int nghiPhep = 0;

                foreach (System.Data.DataRow row in dt.Rows)
                {
                   
                    string trangThai = row["Trạng thái"]?.ToString() ?? "";

                    if (trangThai.Equals("Đang làm việc", StringComparison.OrdinalIgnoreCase))
                    {
                        dangLamViec++;
                    }
                    else if (trangThai.Equals("Nghỉ phép", StringComparison.OrdinalIgnoreCase))
                    {
                        nghiPhep++;
                    }
                }

                lblSodanglam.Text = dangLamViec.ToString("D2");
                lblSonghiphep.Text = nghiPhep.ToString("D2");
            }
        }
        private void CapNhatThongKe(DataTable dt)
        {
            if (dt != null)
            {
                int tongSoNV = dt.Rows.Count;
                lblSonv.Text = tongSoNV.ToString("D2");

                int dangLamViec = 0;
                int nghiPhep = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string trangThai = row["Trạng thái"]?.ToString() ?? "";

                    if (trangThai.Equals("Đang làm việc", StringComparison.OrdinalIgnoreCase))
                    {
                        dangLamViec++;
                    }
                    else if (trangThai.Equals("Nghỉ phép", StringComparison.OrdinalIgnoreCase))
                    {
                        nghiPhep++;
                    }
                }

                lblSodanglam.Text = dangLamViec.ToString("D2");
                lblSonghiphep.Text = nghiPhep.ToString("D2");
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }


        private void btnSuanv_Click(object sender, EventArgs e)
        {

        }


        private void btnXoanv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maNVDuocChon))
            {
                MessageBox.Show("Vui lòng click chọn nhân viên cần xóa!", "Thông báo");
                return;
            }

            DialogResult kq = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {tenNVDuocChon} (Mã: {maNVDuocChon}) không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                if (nhanVienDB.Xoa(maNVDuocChon))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                    maNVDuocChon = "";
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Nhân viên này có thể đang liên quan đến các hóa đơn khác.", "Lỗi");
                }
            }
        }

        
        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];

             
                maNVDuocChon = row.Cells["Column1"].Value?.ToString();
                tenNVDuocChon = row.Cells["Column2"].Value?.ToString();
                gioiTinhDuocChon = row.Cells["Column3"].Value?.ToString();
                sdtDuocChon = row.Cells["Column5"].Value?.ToString();
                chucVuDuocChon = row.Cells["Column6"].Value?.ToString();

                if (row.Cells["Column4"].Value != null && DateTime.TryParse(row.Cells["Column4"].Value.ToString(), out DateTime ns))
                {
                    ngaySinhDuocChon = ns;
                }
                else
                {
                    ngaySinhDuocChon = DateTime.Now;
                }
            }
        }

        private void lblQuanlinv_Click(object sender, EventArgs e)
        {
        }

        private void lblNghiphep_Click(object sender, EventArgs e)
        {
        }

        private void UC_Nhanvien1_Load(object sender, EventArgs e)
        {
        }
    }
}