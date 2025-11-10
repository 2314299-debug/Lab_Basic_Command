namespace Lab_Basic_Command
{
    partial class BillsForm
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.lblTongChuaGiam = new System.Windows.Forms.Label();
            this.lblTongGiam = new System.Windows.Forms.Label();
            this.lblThucThu = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLayDanhsachhoadon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(235, 25);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 31);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(614, 26);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 31);
            this.dtpTo.TabIndex = 1;
            // 
            // dgvBills
            // 
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(25, 201);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 82;
            this.dgvBills.RowTemplate.Height = 33;
            this.dgvBills.Size = new System.Drawing.Size(962, 211);
            this.dgvBills.TabIndex = 2;
            this.dgvBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellDoubleClick);
            // 
            // lblTongChuaGiam
            // 
            this.lblTongChuaGiam.AutoSize = true;
            this.lblTongChuaGiam.Location = new System.Drawing.Point(699, 87);
            this.lblTongChuaGiam.Name = "lblTongChuaGiam";
            this.lblTongChuaGiam.Size = new System.Drawing.Size(26, 25);
            this.lblTongChuaGiam.TabIndex = 3;
            this.lblTongChuaGiam.Text = "\"\"";
            this.lblTongChuaGiam.Click += new System.EventHandler(this.lblTongChuaGiam_Click);
            // 
            // lblTongGiam
            // 
            this.lblTongGiam.AutoSize = true;
            this.lblTongGiam.Location = new System.Drawing.Point(699, 122);
            this.lblTongGiam.Name = "lblTongGiam";
            this.lblTongGiam.Size = new System.Drawing.Size(26, 25);
            this.lblTongGiam.TabIndex = 4;
            this.lblTongGiam.Text = "\"\"";
            // 
            // lblThucThu
            // 
            this.lblThucThu.AutoSize = true;
            this.lblThucThu.Location = new System.Drawing.Point(699, 159);
            this.lblThucThu.Name = "lblThucThu";
            this.lblThucThu.Size = new System.Drawing.Size(26, 25);
            this.lblThucThu.TabIndex = 5;
            this.lblThucThu.Text = "\"\"";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(112, 31);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(93, 25);
            this.lblTuNgay.TabIndex = 6;
            this.lblTuNgay.Text = "Từ Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đến Ngày";
            // 
            // btLayDanhsachhoadon
            // 
            this.btLayDanhsachhoadon.Location = new System.Drawing.Point(117, 137);
            this.btLayDanhsachhoadon.Name = "btLayDanhsachhoadon";
            this.btLayDanhsachhoadon.Size = new System.Drawing.Size(274, 47);
            this.btLayDanhsachhoadon.TabIndex = 8;
            this.btLayDanhsachhoadon.Text = "Lấy danh sách hóa đơn";
            this.btLayDanhsachhoadon.UseVisualStyleBackColor = true;
            this.btLayDanhsachhoadon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tổng chưa giảm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng Giảm\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thực Thu\n";
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLayDanhsachhoadon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.lblThucThu);
            this.Controls.Add(this.lblTongGiam);
            this.Controls.Add(this.lblTongChuaGiam);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "BillsForm";
            this.Text = "BillsForm";
            this.Load += new System.EventHandler(this.BillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Label lblTongChuaGiam;
        private System.Windows.Forms.Label lblTongGiam;
        private System.Windows.Forms.Label lblThucThu;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLayDanhsachhoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}