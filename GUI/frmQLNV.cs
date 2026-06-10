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
    public partial class frmQLNV : Form
    {
        string connStr =
        @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\DELL\Documents\dbCuaHangHoaTuoi.mdf;
            Integrated Security=True;
            Connect Timeout=30";
        public frmQLNV()
        {
            InitializeComponent();
            LoadNhanVien();
        }

        private void lblThemkh_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {

        }
        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM NhanVien";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvNhanvien.DataSource = dt;
            }
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql = @"INSERT INTO NhanVien
            (MaNV,HoTen,GioiTinh,NgaySinh,SoDienThoai,DiaChi)
            VALUES
            (@MaNV,@HoTen,@GioiTinh,@NgaySinh,@SDT,@DiaChi)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaNV", txtManv.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtTennv.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", cboGioitinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaysinh.Value);
                    cmd.Parameters.AddWithValue("@SDT", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    LoadNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
