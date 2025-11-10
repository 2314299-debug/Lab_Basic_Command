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
    public partial class MainForm : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        private int selectedMaBan = -1;
        public MainForm()
        {
            InitializeComponent();
            LoadBan();
            SetupContextMenu();
        }
        private void LoadBan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Bann", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBan.DataSource = dt;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            if (selectedMaBan == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM HoaDonn WHERE MaBan=@MaBan AND Active=1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBan", selectedMaBan);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show($"Hóa đơn hiện tại của bàn: {rd["MaHD"]}\nNgày lập: {rd["NgayLap"]}\nTổng tiền: {rd["TongTien"]}");
                }
                else
                {
                    MessageBox.Show("Bàn hiện không có hóa đơn đang mở!");
                }
                conn.Close();
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Bann (TenBan, MoTa, TrangThai, Active) VALUES (@TenBan, @MoTa, @TrangThai, 1)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@TrangThai", "Trống");
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã thêm bàn mới!");
                LoadBan();
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (selectedMaBan == -1)
            {
                MessageBox.Show("Chọn bàn cần xóa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Bann WHERE MaBan=@MaBan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBan", selectedMaBan);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã xóa bàn!");
                LoadBan();
            }
        }
        private void SetupContextMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Xóa bàn", null, xóaBànToolStripMenuItem_Click);
            menu.Items.Add("Xem danh mục hóa đơn", null, XemDanhMucHoaDon_Click);
            menu.Items.Add("Xem nhật ký hóa đơn", null, XemNhatKyHoaDon_Click);
            dgvBan.ContextMenuStrip = menu;
        }

        private void xóaBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaBan_Click(sender, e);
        }

        private void XemDanhMucHoaDon_Click(object sender, EventArgs e)
        {
            if (selectedMaBan == -1) return;
            FormDanhMucHoaDon f = new FormDanhMucHoaDon(selectedMaBan);
            f.ShowDialog();
        }

        private void XemNhatKyHoaDon_Click(object sender, EventArgs e)
        {
            FormNhatKyHoaDon f = new FormNhatKyHoaDon();
            f.ShowDialog();
        }

        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMaBan = Convert.ToInt32(dgvBan.Rows[e.RowIndex].Cells["MaBan"].Value);
                txtTenBan.Text = dgvBan.Rows[e.RowIndex].Cells["TenBan"].Value.ToString();
                txtMoTa.Text = dgvBan.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
                txtTrangThai.Text = dgvBan.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnCapNhatBan_Click(object sender, EventArgs e)
        {
            if (selectedMaBan == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn cần cập nhật!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Bann SET TenBan = @TenBan, MoTa = @MoTa, TrangThai = @TrangThai WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text);
                cmd.Parameters.AddWithValue("@MoTa", txtMoTa.Text);
                cmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);
                cmd.Parameters.AddWithValue("@MaBan", selectedMaBan);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thông tin bàn thành công!");
                    LoadBan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn để cập nhật!");
                }
            }
        }
    }
}
