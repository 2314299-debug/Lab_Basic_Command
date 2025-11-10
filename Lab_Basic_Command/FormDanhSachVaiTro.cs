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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab_Basic_Command
{
    public partial class FormDanhSachVaiTro : Form
    {
        private string connectionString = "server=Duck; database=QuanLy; Integrated Security=true;";
        private int maTK;
        public FormDanhSachVaiTro(int maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
            LoadVaiTro();
        }
       

        private void FormDanhSachVaiTro_Load(object sender, EventArgs e)
        {
            LoadVaiTro();
        }
        private void LoadVaiTro()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT v.MaVT, v.TenVaiTro, v.MoTa, tv.Active
                               FROM TaiKhoan_VaiTro tv
                               JOIN VaiTro v ON tv.MaVT = v.MaVT
                               WHERE tv.MaTK = @MaTK";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTK", maTK);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvVaiTro.DataSource = dt;
            }
        }
    }
}
