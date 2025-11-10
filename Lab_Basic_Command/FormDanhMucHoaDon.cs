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
    public partial class FormDanhMucHoaDon : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        private int maBan;

        public FormDanhMucHoaDon(int maBan)
        {
            InitializeComponent();
            this.maBan = maBan;
            LoadNgayLap();
        }
        private void LoadNgayLap()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT MaHD, NgayLap FROM HoaDonn WHERE MaBan=@MaBan", conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBoxNgayLap.Items.Add(new { MaHD = reader["MaHD"], NgayLap = reader["NgayLap"] });
                }
                conn.Close();
            }
            listBoxNgayLap.DisplayMember = "NgayLap";
        }

        private void FormDanhMucHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void listBoxNgayLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNgayLap.SelectedItem == null) return;
            dynamic item = listBoxNgayLap.SelectedItem;
            int maHD = item.MaHD;
            LoadChiTietHoaDon(maHD);
        }
        private void LoadChiTietHoaDon(int maHD)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT sp.TenSP, cthd.SoLuong, sp.DonGia, (cthd.SoLuong * sp.DonGia) AS ThanhTien
                               FROM CTHD cthd
                               JOIN SanPham sp ON cthd.MaSP = sp.MaSP
                               WHERE cthd.MaHD = @MaHD";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHD);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTiet.DataSource = dt;
            }
        }
    }
}
