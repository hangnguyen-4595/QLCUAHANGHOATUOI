
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmThongtinnv : Form
    {
        private bool isAddMode; 
        private string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CuaHangHoaTuoi;Integrated Security=True";

        public frmThongtinnv()
        {
            InitializeComponent();
            isAddMode = true;
            lblTieuDe.Text = "THÊM MỚI NHÂN VIÊN";
            txtMaNV.Enabled = true;
        }

        public frmThongtinnv(string ma, string ten, string chucVu, string sdt)
        {
            InitializeComponent();
            isAddMode = false;
            lblTieuDe.Text = "CHỈNH SỬA THÔNG TIN";
            txtMaNV.Text = ma;
            txtMaNV.Enabled = false; 
            txtTenNV.Text = ten;
            cboChucVu.Text = chucVu;
            txtSDT.Text = sdt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên nhân viên!");
                return;
            }

            string query = "";
            if (isAddMode)
            {
                query = "INSERT INTO NHANVIEN (MaNV, TenNV, ChucVu, SDT) VALUES (@Ma, @Ten, @ChucVu, @SDT)";
            }
            else
            {

                query = "UPDATE NHANVIEN SET TenNV = @Ten, ChucVu = @ChucVu, SDT = @SDT WHERE MaNV = @Ma";
            }

            using (SqlConnection con = new SqlConnection(strCon))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Ma", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show(isAddMode ? "Thêm nhân viên thành công!" : "Cập nhật thông tin thành công!", "Thông báo");
                        this.DialogResult = DialogResult.OK; 
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thực thi SQL: " + ex.Message, "Lỗi");
                    }
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}