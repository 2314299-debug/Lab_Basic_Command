namespace Lab_Basic_Command
{
    partial class FormDanhSachVaiTro
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
            this.dgvVaiTro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaiTro
            // 
            this.dgvVaiTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaiTro.Location = new System.Drawing.Point(12, 68);
            this.dgvVaiTro.Name = "dgvVaiTro";
            this.dgvVaiTro.RowHeadersWidth = 82;
            this.dgvVaiTro.RowTemplate.Height = 33;
            this.dgvVaiTro.Size = new System.Drawing.Size(776, 361);
            this.dgvVaiTro.TabIndex = 0;
            // 
            // FormDanhSachVaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVaiTro);
            this.Name = "FormDanhSachVaiTro";
            this.Text = "FormDanhSachVaiTro";
            this.Load += new System.EventHandler(this.FormDanhSachVaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaiTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaiTro;
    }
}