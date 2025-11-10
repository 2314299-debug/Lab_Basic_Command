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
    public partial class BillDetailsForm : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        public BillDetailsForm()
        {
            InitializeComponent();
        }
        public void LoadChiTiet(int maHD)
        {
            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
            string query = @"SELECT ds.TenMon, cthd.SoLuong, cthd.DonGia,
                            (cthd.SoLuong * cthd.DonGia) AS ThanhTien
                     FROM ChiTietHoaDon cthd
                     JOIN DanhSach ds ON cthd.MaMon = ds.MaMon
                     WHERE cthd.MaHD = @MaHD";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaHD", maHD);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChiTiet.DataSource = dt;
                    decimal tongTien = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        tongTien += Convert.ToDecimal(row["ThanhTien"]);
                    }
                    lblTieuDe.Text = "CHI TIẾT HÓA ĐƠN";
                    lblMaHD.Text = "Mã hóa đơn: " + maHD.ToString();
                    lblTongTienHD.Text = "TỔNG TIỀN HÓA ĐƠN: " + tongTien.ToString("N0") + " VNĐ";
                }
                this.Text = $"Chi tiết hóa đơn số {maHD}";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BillDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
