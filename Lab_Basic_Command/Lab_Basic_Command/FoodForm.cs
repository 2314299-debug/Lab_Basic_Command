using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Basic_Command
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadFood(int ma)
        {
            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "SELECT Tenloaimonan FROM Thucan WHERE Maloai = " + ma;
            sqlConnection.Open();

            string Tenloaimonan = sqlCommand.ExecuteScalar()?.ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + Tenloaimonan;

            sqlCommand.CommandText = "SELECT MaMon, TenMon, DonVi, MaNhom, Dongia, GhiChu FROM Danhsach WHERE MaNhom = " + ma;

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable("Danhsach");
            da.Fill(dt);

            dgvDanhsach.DataSource = dt;

            sqlConnection.Close();
            sqlCommand.Dispose();
            da.Dispose();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
             
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhsach.CurrentRow == null)
            {
                MessageBox.Show("⚠️ Hãy chọn một món cần xóa!");
                return;
            }

            int maMon = Convert.ToInt32(dgvDanhsach.CurrentRow.Cells["MaMon"].Value);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa món này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection("server=Duck; database=QuanLy; Integrated Security=true;"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Danhsach WHERE MaMon = @MaMon", conn);
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    cmd.ExecuteNonQuery();
                }

                // Xóa dòng khỏi giao diện
                dgvDanhsach.Rows.RemoveAt(dgvDanhsach.CurrentRow.Index);

                MessageBox.Show("🗑️ Đã xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
