namespace SmartBus.User
{
    partial class UserForm
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
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDBank = new System.Windows.Forms.TextBox();
            this.lbXeDangNgoi = new System.Windows.Forms.Label();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.cbHocSinh = new System.Windows.Forms.CheckBox();
            this.btnXemTram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(19, 79);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(58, 13);
            this.lbTaiKhoan.TabIndex = 0;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(19, 110);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(29, 13);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngân hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Học sinh:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(110, 76);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(100, 20);
            this.txtAccount.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 107);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtIDBank
            // 
            this.txtIDBank.Location = new System.Drawing.Point(110, 138);
            this.txtIDBank.Name = "txtIDBank";
            this.txtIDBank.ReadOnly = true;
            this.txtIDBank.Size = new System.Drawing.Size(100, 20);
            this.txtIDBank.TabIndex = 7;
            // 
            // lbXeDangNgoi
            // 
            this.lbXeDangNgoi.AutoSize = true;
            this.lbXeDangNgoi.Location = new System.Drawing.Point(19, 200);
            this.lbXeDangNgoi.Name = "lbXeDangNgoi";
            this.lbXeDangNgoi.Size = new System.Drawing.Size(74, 13);
            this.lbXeDangNgoi.TabIndex = 10;
            this.lbXeDangNgoi.Text = "Xe đang ngồi:";
            // 
            // txtXe
            // 
            this.txtXe.Location = new System.Drawing.Point(110, 197);
            this.txtXe.Name = "txtXe";
            this.txtXe.ReadOnly = true;
            this.txtXe.Size = new System.Drawing.Size(36, 20);
            this.txtXe.TabIndex = 11;
            // 
            // cbHocSinh
            // 
            this.cbHocSinh.AutoSize = true;
            this.cbHocSinh.Location = new System.Drawing.Point(110, 172);
            this.cbHocSinh.Name = "cbHocSinh";
            this.cbHocSinh.Size = new System.Drawing.Size(15, 14);
            this.cbHocSinh.TabIndex = 12;
            this.cbHocSinh.UseVisualStyleBackColor = true;
            // 
            // btnXemTram
            // 
            this.btnXemTram.Location = new System.Drawing.Point(161, 195);
            this.btnXemTram.Name = "btnXemTram";
            this.btnXemTram.Size = new System.Drawing.Size(75, 23);
            this.btnXemTram.TabIndex = 13;
            this.btnXemTram.Text = "Xem trạm";
            this.btnXemTram.UseVisualStyleBackColor = true;
            this.btnXemTram.Click += new System.EventHandler(this.BtnXemTram_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 231);
            this.Controls.Add(this.btnXemTram);
            this.Controls.Add(this.cbHocSinh);
            this.Controls.Add(this.txtXe);
            this.Controls.Add(this.lbXeDangNgoi);
            this.Controls.Add(this.txtIDBank);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbTaiKhoan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDBank;
        private System.Windows.Forms.Label lbXeDangNgoi;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.CheckBox cbHocSinh;
        private System.Windows.Forms.Button btnXemTram;
    }
}