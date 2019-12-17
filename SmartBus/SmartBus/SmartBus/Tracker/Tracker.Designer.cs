namespace SmartBus.Tracker
{
    partial class Tracker
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
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbIDBus = new System.Windows.Forms.Label();
            this.lbStationGoOn = new System.Windows.Forms.Label();
            this.lbStationGoOut = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtIDBus = new System.Windows.Forms.TextBox();
            this.txtStationGoOn = new System.Windows.Forms.TextBox();
            this.txtStationGoOut = new System.Windows.Forms.TextBox();
            this.dgvTracker = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(40, 54);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(58, 13);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Tài khoản:";
            // 
            // lbIDBus
            // 
            this.lbIDBus.AutoSize = true;
            this.lbIDBus.Location = new System.Drawing.Point(40, 86);
            this.lbIDBus.Name = "lbIDBus";
            this.lbIDBus.Size = new System.Drawing.Size(46, 13);
            this.lbIDBus.TabIndex = 1;
            this.lbIDBus.Text = "Ngồi xe:";
            // 
            // lbStationGoOn
            // 
            this.lbStationGoOn.AutoSize = true;
            this.lbStationGoOn.Location = new System.Drawing.Point(40, 118);
            this.lbStationGoOn.Name = "lbStationGoOn";
            this.lbStationGoOn.Size = new System.Drawing.Size(51, 13);
            this.lbStationGoOn.TabIndex = 2;
            this.lbStationGoOn.Text = "Trạm lên:";
            // 
            // lbStationGoOut
            // 
            this.lbStationGoOut.AutoSize = true;
            this.lbStationGoOut.Location = new System.Drawing.Point(158, 118);
            this.lbStationGoOut.Name = "lbStationGoOut";
            this.lbStationGoOut.Size = new System.Drawing.Size(51, 13);
            this.lbStationGoOut.TabIndex = 3;
            this.lbStationGoOut.Text = "Trạm lên:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(104, 51);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(211, 20);
            this.txtAccount.TabIndex = 4;
            // 
            // txtIDBus
            // 
            this.txtIDBus.Location = new System.Drawing.Point(104, 83);
            this.txtIDBus.Name = "txtIDBus";
            this.txtIDBus.Size = new System.Drawing.Size(47, 20);
            this.txtIDBus.TabIndex = 5;
            // 
            // txtStationGoOn
            // 
            this.txtStationGoOn.Location = new System.Drawing.Point(104, 115);
            this.txtStationGoOn.Name = "txtStationGoOn";
            this.txtStationGoOn.Size = new System.Drawing.Size(47, 20);
            this.txtStationGoOn.TabIndex = 6;
            // 
            // txtStationGoOut
            // 
            this.txtStationGoOut.Location = new System.Drawing.Point(215, 115);
            this.txtStationGoOut.Name = "txtStationGoOut";
            this.txtStationGoOut.Size = new System.Drawing.Size(47, 20);
            this.txtStationGoOut.TabIndex = 7;
            // 
            // dgvTracker
            // 
            this.dgvTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracker.Location = new System.Drawing.Point(1, 148);
            this.dgvTracker.Name = "dgvTracker";
            this.dgvTracker.Size = new System.Drawing.Size(486, 148);
            this.dgvTracker.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 302);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Xóa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(295, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sửa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(156, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "MÁY KIỂM TRA";
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTracker);
            this.Controls.Add(this.txtStationGoOut);
            this.Controls.Add(this.txtStationGoOn);
            this.Controls.Add(this.txtIDBus);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lbStationGoOut);
            this.Controls.Add(this.lbStationGoOn);
            this.Controls.Add(this.lbIDBus);
            this.Controls.Add(this.lbAccount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tracker";
            this.Text = "Máy kiểm tra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbIDBus;
        private System.Windows.Forms.Label lbStationGoOn;
        private System.Windows.Forms.Label lbStationGoOut;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtIDBus;
        private System.Windows.Forms.TextBox txtStationGoOn;
        private System.Windows.Forms.TextBox txtStationGoOut;
        private System.Windows.Forms.DataGridView dgvTracker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
    }
}