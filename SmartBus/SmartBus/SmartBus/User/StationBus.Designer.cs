namespace SmartBus.User
{
    partial class StationBus
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.dgvTram = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTram)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbHeader.Location = new System.Drawing.Point(117, 25);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(281, 31);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thông tin trạm của xe ";
            // 
            // dgvTram
            // 
            this.dgvTram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTram.Location = new System.Drawing.Point(2, 83);
            this.dgvTram.Name = "dgvTram";
            this.dgvTram.Size = new System.Drawing.Size(533, 250);
            this.dgvTram.TabIndex = 1;
            // 
            // StationBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 335);
            this.Controls.Add(this.dgvTram);
            this.Controls.Add(this.lbHeader);
            this.Name = "StationBus";
            this.Text = "StationBus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.DataGridView dgvTram;
    }
}