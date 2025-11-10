namespace Lab_Basic_Command
{
    partial class MainForm
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
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.btnCapNhatBan = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XemDanhMucHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.XemNhatKyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Location = new System.Drawing.Point(758, 146);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(172, 45);
            this.btnXemHoaDon.TabIndex = 0;
            this.btnXemHoaDon.Text = "Xem Hóa Đơn";
            this.btnXemHoaDon.UseVisualStyleBackColor = true;
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // dgvBan
            // 
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Location = new System.Drawing.Point(22, 211);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.RowHeadersWidth = 82;
            this.dgvBan.RowTemplate.Height = 33;
            this.dgvBan.Size = new System.Drawing.Size(1152, 251);
            this.dgvBan.TabIndex = 1;
            this.dgvBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellContentClick);
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(207, 25);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(243, 31);
            this.txtTenBan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Bàn";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(207, 82);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(243, 31);
            this.txtMoTa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô tả";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(207, 140);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(243, 31);
            this.txtTrangThai.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng Thái";
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(547, 68);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(172, 45);
            this.btnThemBan.TabIndex = 8;
            this.btnThemBan.Text = "Thêm Bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnCapNhatBan
            // 
            this.btnCapNhatBan.Location = new System.Drawing.Point(758, 65);
            this.btnCapNhatBan.Name = "btnCapNhatBan";
            this.btnCapNhatBan.Size = new System.Drawing.Size(172, 45);
            this.btnCapNhatBan.TabIndex = 9;
            this.btnCapNhatBan.Text = "Cập Nhật";
            this.btnCapNhatBan.UseVisualStyleBackColor = true;
            this.btnCapNhatBan.Click += new System.EventHandler(this.btnCapNhatBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(959, 65);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(172, 45);
            this.btnXoaBan.TabIndex = 10;
            this.btnXoaBan.Text = "Xóa";
            this.btnXoaBan.UseVisualStyleBackColor = true;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaBànToolStripMenuItem,
            this.XemDanhMucHoaDon,
            this.XemNhatKyHoaDon});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(347, 118);
            // 
            // xóaBànToolStripMenuItem
            // 
            this.xóaBànToolStripMenuItem.Name = "xóaBànToolStripMenuItem";
            this.xóaBànToolStripMenuItem.Size = new System.Drawing.Size(346, 38);
            this.xóaBànToolStripMenuItem.Text = "Xóa Bàn";
            this.xóaBànToolStripMenuItem.Click += new System.EventHandler(this.xóaBànToolStripMenuItem_Click);
            // 
            // XemDanhMucHoaDon
            // 
            this.XemDanhMucHoaDon.Name = "XemDanhMucHoaDon";
            this.XemDanhMucHoaDon.Size = new System.Drawing.Size(346, 38);
            this.XemDanhMucHoaDon.Text = "Xem danh mục hóa đơn";
            this.XemDanhMucHoaDon.Click += new System.EventHandler(this.XemDanhMucHoaDon_Click);
            // 
            // XemNhatKyHoaDon
            // 
            this.XemNhatKyHoaDon.Name = "XemNhatKyHoaDon";
            this.XemNhatKyHoaDon.Size = new System.Drawing.Size(346, 38);
            this.XemNhatKyHoaDon.Text = "Xem nhật ký hóa đơn";
            this.XemNhatKyHoaDon.Click += new System.EventHandler(this.XemNhatKyHoaDon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 473);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnCapNhatBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.dgvBan);
            this.Controls.Add(this.btnXemHoaDon);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemHoaDon;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnCapNhatBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XemDanhMucHoaDon;
        private System.Windows.Forms.ToolStripMenuItem XemNhatKyHoaDon;
    }
}