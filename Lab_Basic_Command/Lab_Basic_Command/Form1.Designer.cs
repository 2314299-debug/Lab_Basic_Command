namespace Lab_Basic_Command
{
    partial class Form1
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
            this.btLayDS = new System.Windows.Forms.Button();
            this.lvDS = new System.Windows.Forms.ListView();
            this.chMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTenloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
            this.btThem = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLayDS
            // 
            this.btLayDS.Location = new System.Drawing.Point(49, 198);
            this.btLayDS.Name = "btLayDS";
            this.btLayDS.Size = new System.Drawing.Size(205, 50);
            this.btLayDS.TabIndex = 0;
            this.btLayDS.Text = "Lấy Danh Sách";
            this.btLayDS.UseVisualStyleBackColor = true;
            this.btLayDS.Click += new System.EventHandler(this.btLayDS_Click);
            // 
            // lvDS
            // 
            this.lvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMa,
            this.chTenloai,
            this.chLoai});
            this.lvDS.ContextMenuStrip = this.contextMenuStrip1;
            this.lvDS.FullRowSelect = true;
            this.lvDS.HideSelection = false;
            this.lvDS.Location = new System.Drawing.Point(44, 267);
            this.lvDS.MultiSelect = false;
            this.lvDS.Name = "lvDS";
            this.lvDS.Size = new System.Drawing.Size(1184, 465);
            this.lvDS.TabIndex = 1;
            this.lvDS.UseCompatibleStateImageBehavior = false;
            this.lvDS.View = System.Windows.Forms.View.Details;
            this.lvDS.Click += new System.EventHandler(this.lvDS_Click);
            // 
            // chMa
            // 
            this.chMa.Text = "Mã Loại";
            this.chMa.Width = 161;
            // 
            // chTenloai
            // 
            this.chTenloai.Text = "Tên Loại Món Ăn";
            this.chTenloai.Width = 300;
            // 
            // chLoai
            // 
            this.chLoai.Text = "Loại";
            this.chLoai.Width = 239;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(341, 80);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(340, 38);
            this.tsmDelete.Text = "Xóa nhóm sản phẩm";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmViewFood
            // 
            this.tsmViewFood.Name = "tsmViewFood";
            this.tsmViewFood.Size = new System.Drawing.Size(340, 38);
            this.tsmViewFood.Text = "Xem danh sách món ăn";
            this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(470, 198);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(205, 50);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Enabled = false;
            this.btCapNhat.Location = new System.Drawing.Point(709, 198);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(205, 50);
            this.btCapNhat.TabIndex = 3;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Location = new System.Drawing.Point(949, 198);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(205, 50);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Nhóm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Nhóm Thức Ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại :";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(279, 42);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(471, 31);
            this.txtMa.TabIndex = 8;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(279, 93);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(471, 31);
            this.txtTenNhom.TabIndex = 9;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(279, 148);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(471, 31);
            this.txtLoai.TabIndex = 10;
            this.txtLoai.TextChanged += new System.EventHandler(this.txtLoai_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 758);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.lvDS);
            this.Controls.Add(this.btLayDS);
            this.Name = "Form1";
            this.Text = "Quân lý nhóm thức ăn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLayDS;
        private System.Windows.Forms.ListView lvDS;
        private System.Windows.Forms.ColumnHeader chMa;
        private System.Windows.Forms.ColumnHeader chTenloai;
        private System.Windows.Forms.ColumnHeader chLoai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
    }
}

