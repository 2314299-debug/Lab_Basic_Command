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
    public partial class AccountManager : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        private DataTable dtTaiKhoan;
        private SqlDataAdapter adapter;
        private int selectedMaTK = -1;
        public AccountManager()
        {
            InitializeComponent();
            LoadAccounts();
            SetupContextMenu();
        }
      
        
        private void AccountManager_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadAccounts(string nhom = "", bool? active = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaTK, TenDangNhap, MatKhau, Nhom, Active FROM TaiKhoann WHERE 1=1";
                if (!string.IsNullOrEmpty(nhom))
                    sql += " AND Nhom = @Nhom";
                if (active.HasValue)
                    sql += " AND Active = @Active";

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (!string.IsNullOrEmpty(nhom))
                    cmd.Parameters.AddWithValue("@Nhom", nhom);
                if (active.HasValue)
                    cmd.Parameters.AddWithValue("@Active", active.Value);

                adapter = new SqlDataAdapter(cmd);
                dtTaiKhoan = new DataTable();
                adapter.Fill(dtTaiKhoan);
                dgvTaiKhoan.DataSource = dtTaiKhoan;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO TaiKhoann (TenDangNhap, MatKhau, Nhom, Active) VALUES (@TenDN, @MatKhau, @Nhom, @Active)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@Nhom", txtNhom.Text);
                cmd.Parameters.AddWithValue("@Active", chkActive.Checked);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã thêm tài khoản mới!");
                LoadAccounts();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (selectedMaTK == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE TaiKhoann SET TenDangNhap=@TenDN, MatKhau=@MatKhau, Nhom=@Nhom, Active=@Active WHERE MaTK=@MaTK";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@Nhom", txtNhom.Text);
                cmd.Parameters.AddWithValue("@Active", chkActive.Checked);
                cmd.Parameters.AddWithValue("@MaTK", selectedMaTK);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cập nhật thành công!");
                LoadAccounts();
            }
        }

        private void btnResetMK_Click(object sender, EventArgs e)
        {
            if (selectedMaTK == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần reset!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE TaiKhoann SET MatKhau='123456' WHERE MaTK=@MaTK";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTK", selectedMaTK);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Reset mật khẩu về mặc định: 123456");
                LoadAccounts();
            }
        }
        private void SetupContextMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Xóa tài khoản", null, xóaToolStripMenuItem_Click);
            menu.Items.Add("Xem danh sách vai trò", null, thêmVaiTròToolStripMenuItem_Click);
            dgvTaiKhoan.ContextMenuStrip = menu;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMaTK == -1)
            {
                MessageBox.Show("Chọn tài khoản cần xóa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql1 = "UPDATE TaiKhoan SET Active = 0 WHERE MaTK=@MaTK";
                string sql2 = "UPDATE TaiKhoan_VaiTro SET Active = 0 WHERE MaTK=@MaTK";

                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd1.Parameters.AddWithValue("@MaTK", selectedMaTK);
                cmd2.Parameters.AddWithValue("@MaTK", selectedMaTK);

                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Đã xóa tài khoản (và vô hiệu hóa vai trò)!");
                LoadAccounts();
            }
        }
        

        private void thêmVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMaTK == -1)
            {
                MessageBox.Show("Chọn tài khoản cần xem!");
                return;
            }

            FormDanhSachVaiTro f = new FormDanhSachVaiTro(selectedMaTK);
            f.ShowDialog();
        }

        private void menuTaiKhoan_Opening(object sender, CancelEventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null)
            {
                e.Cancel = true;
            }
        }

        private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void chkTrangthai_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMaTK = Convert.ToInt32(dgvTaiKhoan.Rows[e.RowIndex].Cells["MaTK"].Value);
                txtTenDN.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                txtNhom.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["Nhom"].Value.ToString();
                chkActive.Checked = Convert.ToBoolean(dgvTaiKhoan.Rows[e.RowIndex].Cells["Active"].Value);
            }
        }
    }
}
