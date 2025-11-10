namespace Lab_Basic_Command
{
    partial class FoodForm
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
            this.dgvDanhsach = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clManhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhsach
            // 
            this.dgvDanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTenmon,
            this.clDonvi,
            this.clManhom,
            this.clDongia,
            this.clGhichu});
            this.dgvDanhsach.Location = new System.Drawing.Point(-2, 12);
            this.dgvDanhsach.Name = "dgvDanhsach";
            this.dgvDanhsach.RowHeadersWidth = 82;
            this.dgvDanhsach.RowTemplate.Height = 33;
            this.dgvDanhsach.Size = new System.Drawing.Size(1296, 377);
            this.dgvDanhsach.TabIndex = 0;
            this.dgvDanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsach_CellContentClick);
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "Mamon";
            this.clMa.HeaderText = "Mã món";
            this.clMa.MinimumWidth = 10;
            this.clMa.Name = "clMa";
            // 
            // clTenmon
            // 
            this.clTenmon.DataPropertyName = "Tenmon";
            this.clTenmon.HeaderText = "Tên món";
            this.clTenmon.MinimumWidth = 10;
            this.clTenmon.Name = "clTenmon";
            this.clTenmon.Width = 200;
            // 
            // clDonvi
            // 
            this.clDonvi.DataPropertyName = "Donvi";
            this.clDonvi.HeaderText = "Đơn vị tính";
            this.clDonvi.MinimumWidth = 10;
            this.clDonvi.Name = "clDonvi";
            this.clDonvi.Width = 50;
            // 
            // clManhom
            // 
            this.clManhom.DataPropertyName = "Manhom";
            this.clManhom.HeaderText = "Mã nhóm";
            this.clManhom.MinimumWidth = 10;
            this.clManhom.Name = "clManhom";
            this.clManhom.Width = 40;
            // 
            // clDongia
            // 
            this.clDongia.DataPropertyName = "Dongia";
            this.clDongia.HeaderText = "Đơn giá";
            this.clDongia.MinimumWidth = 10;
            this.clDongia.Name = "clDongia";
            this.clDongia.Width = 50;
            // 
            // clGhichu
            // 
            this.clGhichu.DataPropertyName = "Ghichu";
            this.clGhichu.HeaderText = "Ghi chú";
            this.clGhichu.MinimumWidth = 10;
            this.clGhichu.Name = "clGhichu";
            this.clGhichu.Width = 200;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(786, 406);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(122, 40);
            this.btLuu.TabIndex = 1;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(949, 406);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(122, 40);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 458);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.dgvDanhsach);
            this.Name = "FoodForm";
            this.Text = "Danh sách món ăn";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clManhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhichu;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
    }
}