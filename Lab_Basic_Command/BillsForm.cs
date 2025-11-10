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
    public partial class BillsForm : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        public BillsForm()
        {
            InitializeComponent();
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
        }

        private void btnLoadBills_Click(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void LoadBills()
        {
            string query = @"
                SELECT MaHD, NgayBan, TongTien, GiamGia, (TongTien - GiamGia) AS ThucThu
                FROM HoaDon
                WHERE NgayBan BETWEEN @from AND @to
                ORDER BY NgayBan DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBills.DataSource = dt;

                // Tính tổng
                decimal tongTien = 0, tongGiam = 0, thucThu = 0;

                foreach (DataRow row in dt.Rows)
                {
                    tongTien += Convert.ToDecimal(row["TongTien"]);
                    tongGiam += Convert.ToDecimal(row["GiamGia"]);
                    thucThu += Convert.ToDecimal(row["ThucThu"]);
                }

                lblTongChuaGiam.Text = $"Tổng tiền chưa giảm: {tongTien:N0} VNĐ";
                lblTongGiam.Text = $"Tổng giảm giá: {tongGiam:N0} VNĐ";
                lblThucThu.Text = $"Thực thu: {thucThu:N0} VNĐ";
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHD = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Đang mở chi tiết hóa đơn: " + maHD);

                BillDetailsForm detailsForm = new BillDetailsForm();
                detailsForm.LoadChiTiet(maHD);
                detailsForm.ShowDialog();
            }
        }
        private void lblTongChuaGiam_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpFrom.Value.Date;
            DateTime denNgay = dtpTo.Value.Date;

            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
            string query = @"SELECT MaHD, NgayBan, TongTien, GiamGia
                             FROM HoaDon
                             WHERE NgayBan BETWEEN @TuNgay AND @DenNgay
                             ORDER BY NgayBan ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị dữ liệu lên DataGridView
                dgvBills.DataSource = dt;

                // Tính tổng
                decimal tongChuaGiam = 0;
                decimal tongGiam = 0;

                foreach (DataRow row in dt.Rows)
                {
                    tongChuaGiam += Convert.ToDecimal(row["TongTien"]);
                    tongGiam += Convert.ToDecimal(row["GiamGia"]);
                }

                decimal thucThu = tongChuaGiam - tongGiam;

                lblTongChuaGiam.Text = tongChuaGiam.ToString("N0") + " đ";
                lblTongGiam.Text = tongGiam.ToString("N0") + " đ";
                lblThucThu.Text = thucThu.ToString("N0") + " đ";
               
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
