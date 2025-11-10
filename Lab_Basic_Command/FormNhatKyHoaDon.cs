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
    public partial class FormNhatKyHoaDon : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        public FormNhatKyHoaDon()
        {
            InitializeComponent();
            LoadThongKe();
        }
        private void LoadThongKe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT MaHD, NgayLap, NhanVien, TongTien, Thue, GiamGia
                               FROM HoaDonn";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNhatKy.DataSource = dt;

                // Thống kê tổng hợp
                decimal tongTien = 0, tongThue = 0, tongGiam = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongTien += Convert.ToDecimal(row["TongTien"]);
                    tongThue += Convert.ToDecimal(row["Thue"]);
                    tongGiam += Convert.ToDecimal(row["GiamGia"]);
                }

                lblTongHD.Text = "Số lượng hóa đơn: " + dt.Rows.Count;
                lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0");
                lblTongThue.Text = "Tổng thuế: " + tongThue.ToString("N0");
                lblTongGiam.Text = "Tổng giảm giá: " + tongGiam.ToString("N0");
            }
        }
        private void FormNhatKyHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
