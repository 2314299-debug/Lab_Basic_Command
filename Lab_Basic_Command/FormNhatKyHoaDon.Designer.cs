namespace Lab_Basic_Command
{
    partial class FormNhatKyHoaDon
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
            this.dgvNhatKy = new System.Windows.Forms.DataGridView();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongThue = new System.Windows.Forms.Label();
            this.lblTongGiam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhatKy
            // 
            this.dgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKy.Location = new System.Drawing.Point(12, 159);
            this.dgvNhatKy.Name = "dgvNhatKy";
            this.dgvNhatKy.RowHeadersWidth = 82;
            this.dgvNhatKy.RowTemplate.Height = 33;
            this.dgvNhatKy.Size = new System.Drawing.Size(1028, 279);
            this.dgvNhatKy.TabIndex = 0;
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Location = new System.Drawing.Point(493, 56);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(36, 25);
            this.lblTongHD.TabIndex = 1;
            this.lblTongHD.Text = "__";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(493, 102);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(36, 25);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "__";
            // 
            // lblTongThue
            // 
            this.lblTongThue.AutoSize = true;
            this.lblTongThue.Location = new System.Drawing.Point(804, 44);
            this.lblTongThue.Name = "lblTongThue";
            this.lblTongThue.Size = new System.Drawing.Size(36, 25);
            this.lblTongThue.TabIndex = 3;
            this.lblTongThue.Text = "__";
            // 
            // lblTongGiam
            // 
            this.lblTongGiam.AutoSize = true;
            this.lblTongGiam.Location = new System.Drawing.Point(804, 102);
            this.lblTongGiam.Name = "lblTongGiam";
            this.lblTongGiam.Size = new System.Drawing.Size(36, 25);
            this.lblTongGiam.TabIndex = 4;
            this.lblTongGiam.Text = "__";
            // 
            // FormNhatKyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.lblTongGiam);
            this.Controls.Add(this.lblTongThue);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTongHD);
            this.Controls.Add(this.dgvNhatKy);
            this.Name = "FormNhatKyHoaDon";
            this.Text = "FormNhatKyHoaDon";
            this.Load += new System.EventHandler(this.FormNhatKyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhatKy;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongThue;
        private System.Windows.Forms.Label lblTongGiam;
    }
}