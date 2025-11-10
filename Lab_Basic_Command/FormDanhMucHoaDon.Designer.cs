namespace Lab_Basic_Command
{
    partial class FormDanhMucHoaDon
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
            this.listBoxNgayLap = new System.Windows.Forms.ListBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxNgayLap
            // 
            this.listBoxNgayLap.FormattingEnabled = true;
            this.listBoxNgayLap.ItemHeight = 25;
            this.listBoxNgayLap.Location = new System.Drawing.Point(21, 167);
            this.listBoxNgayLap.Name = "listBoxNgayLap";
            this.listBoxNgayLap.Size = new System.Drawing.Size(427, 279);
            this.listBoxNgayLap.TabIndex = 0;
            this.listBoxNgayLap.SelectedIndexChanged += new System.EventHandler(this.listBoxNgayLap_SelectedIndexChanged);
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(454, 167);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 82;
            this.dgvChiTiet.RowTemplate.Height = 33;
            this.dgvChiTiet.Size = new System.Drawing.Size(1217, 279);
            this.dgvChiTiet.TabIndex = 1;
            // 
            // FormDanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 450);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.listBoxNgayLap);
            this.Name = "FormDanhMucHoaDon";
            this.Text = "FormDanhMucHoaDon";
            this.Load += new System.EventHandler(this.FormDanhMucHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNgayLap;
        private System.Windows.Forms.DataGridView dgvChiTiet;
    }
}