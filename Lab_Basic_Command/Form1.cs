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

namespace Lab_Basic_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLayDS_Click(object sender, EventArgs e)
        {
            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string qr = "SELECT Maloai,Tenloaimonan,Loai FROM Thucan";
            sqlCommand.CommandText = qr;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayFrom1(sqlDataReader);
            sqlConnection.Close();
        }
        private void DisplayFrom1(SqlDataReader rd)
        {
            lvDS.Items.Clear();
            while(rd.Read())
            {
                ListViewItem item = new ListViewItem(rd["Maloai"].ToString());
                lvDS.Items.Add(item);
                item.SubItems.Add(rd["Tenloaimonan"].ToString());
                item.SubItems.Add(rd["Loai"].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "INSERT INTO Thucan(Tenloaimonan,Loai)" +
                " VALUES(N'" + txtTenNhom.Text + "'," + txtLoai.Text +")"; ;
            sqlConnection.Open();
            int numOfRowsAffected = sqlCommand.ExecuteNonQuery(); 
            sqlConnection.Close();

            if (numOfRowsAffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);

                btLayDS.PerformClick();
                txtTenNhom.Text = "";
                txtLoai.Text = "";
            }
            else
                MessageBox.Show("Thêm nhóm món ăn thất bại");
        }

        private void lvDS_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvDS.SelectedItems[0];  
            txtMa.Text = item.Text;
            txtTenNhom.Text = item.SubItems[1].Text;
            txtLoai.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

            btCapNhat.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "DELETE FROM Thucan WHERE Maloai=" + txtMa.Text;
            sqlConnection.Open();
            int numOfRowsAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (numOfRowsAffected == 1)
            {
                ListViewItem item = lvDS.SelectedItems[0];
                lvDS.Items.Remove(item);

                txtMa.Text = "";
                txtTenNhom.Text = "";
                txtLoai.Text = "";

                btCapNhat.Enabled = false;
                btXoa.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công ","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Thucan SET Tenloaimonan = @Tenloaimonan, [Loai] = @Loai WHERE Maloai = @Maloai";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Tenloaimonan", txtTenNhom.Text);

                    sqlCommand.Parameters.AddWithValue("@Loai", txtLoai.Text == "Thức uống" ? 0 : 1);
                    sqlCommand.Parameters.AddWithValue("@Maloai", Convert.ToInt32(txtMa.Text));

                    sqlConnection.Open();
                    int numRowsAffected = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    if (numRowsAffected == 1)
                    {
                        MessageBox.Show("Cập nhật nhóm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào được cập nhật. Kiểm tra lại ID!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                btXoa.PerformClick();
            }
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if (txtMa.Text !="")
            {
                FoodForm foodForm = new FoodForm();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtMa.Text));
            }
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            BillsForm billsForm = new BillsForm();
            billsForm.ShowDialog();

            
            
        }

        private void lvDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
