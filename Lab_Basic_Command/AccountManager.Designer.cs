namespace Lab_Basic_Command
{
    partial class AccountManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnResetMK = new System.Windows.Forms.Button();
            this.menuTaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.menuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(12, 259);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 82;
            this.dgvTaiKhoan.RowTemplate.Height = 33;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(942, 261);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(609, 121);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(134, 29);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Kích hoạt";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkTrangthai_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(295, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(476, 191);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(137, 45);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnResetMK
            // 
            this.btnResetMK.Location = new System.Drawing.Point(643, 192);
            this.btnResetMK.Name = "btnResetMK";
            this.btnResetMK.Size = new System.Drawing.Size(137, 45);
            this.btnResetMK.TabIndex = 5;
            this.btnResetMK.Text = "Reset MK";
            this.btnResetMK.UseVisualStyleBackColor = true;
            this.btnResetMK.Click += new System.EventHandler(this.btnResetMK_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.xemVaiTròToolStripMenuItem});
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(211, 80);
            this.menuTaiKhoan.Opening += new System.ComponentModel.CancelEventHandler(this.menuTaiKhoan_Opening);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // xemVaiTròToolStripMenuItem
            // 
            this.xemVaiTròToolStripMenuItem.Name = "xemVaiTròToolStripMenuItem";
            this.xemVaiTròToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.xemVaiTròToolStripMenuItem.Text = "Xem vai trò";
            this.xemVaiTròToolStripMenuItem.Click += new System.EventHandler(this.thêmVaiTròToolStripMenuItem_Click);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(252, 26);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(292, 31);
            this.txtTenDN.TabIndex = 6;
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(53, 32);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(163, 25);
            this.lbTenDangNhap.TabIndex = 7;
            this.lbTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(252, 78);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(292, 31);
            this.txtMatKhau.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhóm";
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(252, 121);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(292, 31);
            this.txtNhom.TabIndex = 11;
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 542);
            this.Controls.Add(this.txtNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.btnResetMK);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.menuTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnResetMK;
        private System.Windows.Forms.ContextMenuStrip menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemVaiTròToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhom;
    }
}