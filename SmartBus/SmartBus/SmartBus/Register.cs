using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBus
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private int CheckInfo()
        {
            //2 == không được để rỗng
            //1 == tài khoản đã tồn tại
            //0 == thành công
            int Result = 0; 
            string Username = txtTaiKhoan.Text.Trim();
            string Password = txtPassWord.Text;
            string Name = txtPassWord.Text;
            int Age = 0;
            if (txtIDBank.Text != string.Empty)
            {
                Age = int.Parse(txtTuoi.Text);
            }
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Temp = db.CUSTOMERs.Where(s => s.USERID == Username).SingleOrDefault();
            if (Username.Length == 0 || Password.Length == 0|| Name.Length == 0
                || txtTuoi.Text.Length == 0 || txtIDBank.Text.Length == 0)
            {
                Result = 2;
            }
            else if (Temp != null)
            {
                Result = 1;
            }
            else
            {
                Result = 0;
            }
            return Result;
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            int value = CheckInfo();
            if (value == 0)
            {
                CUSTOMER cus = new CUSTOMER();
                cus.USERID = txtTaiKhoan.Text.Trim();
                cus.PASSWORDID = txtPassWord.Text.Trim();
                cus.NAMECUS = txtTen.Text.Trim();
                cus.AGECUS = int.Parse(txtTuoi.Text.Trim());
                cus.ISSTUDENT = checkBox1.Checked;
                cus.BANKID = txtIDBank.Text.Trim();

                DataClasses1DataContext db = new DataClasses1DataContext();
                var bank = db.BANKs.Where(s => s.BANKID == cus.BANKID).SingleOrDefault();
                if (bank== null)
                {
                    BANK banking = new BANK();
                    banking.BANKID = cus.BANKID;
                    banking.BANKMONEY = 200000;
                    db.BANKs.InsertOnSubmit(banking);
                    db.SubmitChanges();
                }
                db.CUSTOMERs.InsertOnSubmit(cus);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký thành công", "Chúc mừng");
                this.Close();
            }
            else if (value == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi");
            }
        }
    }
}
