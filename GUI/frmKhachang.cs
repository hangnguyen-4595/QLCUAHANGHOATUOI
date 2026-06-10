using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLCUAHANGHOATUOI.GUI
{
    public partial class frmKhachang : Form
    {
        string connStr =
        @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\DELL\Documents\dbCuaHangHoaTuoi.mdf;
        Integrated Security=True;
        Connect Timeout=30 ";

        public frmKhachang()
        {
            InitializeComponent();
            dgvKhachhang.AutoGenerateColumns = true;
            LoadDataFromDB();
        }

        private void lblHoadon_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachang_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMakh_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblThemkh_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataFromDB()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM KhachHang";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvKhachhang.DataSource = null;
                dgvKhachhang.DataSource = dt;
            }
        }

        private void btnThemkh_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql = @"INSERT INTO KhachHang
                           (MaKH, HoTen, SoDienThoai, DiaChi)
                           VALUES
                           (@MaKH, @HoTen, @SDT, @DiaChi)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaKH", txtMakh.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtTenkh.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm khách hàng thành công!");

                    LoadDataFromDB();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMakh.Text = dgvKhachhang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                txtTenkh.Text = dgvKhachhang.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtSdt.Text = dgvKhachhang.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
                txtDiachi.Text = dgvKhachhang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            }
        }
    }
}