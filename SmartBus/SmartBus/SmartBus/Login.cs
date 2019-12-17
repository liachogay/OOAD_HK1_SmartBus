using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBus.User;
using SmartBus.Tracker;

namespace SmartBus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                string Username = txtTaiKhoan.Text.Trim();
                string Password = txtPassWord.Text.Trim();
                this.Visible = false;
                if (Username.ToLower() == "tracker")
                {
                    TrackerForm tracker = new TrackerForm();
                    tracker.ShowDialog();

                }
                else if (Username.ToLower() == "admin")
                {

                }
                else
                {
                    DataClasses1DataContext db = new DataClasses1DataContext();
                    var a = db.CUSTOMERs.Where(s => s.USERID == Username).SingleOrDefault();
                    UserForm UF = new UserForm(a);
                    UF.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Sai thông tin");
            }
        }

        private bool CheckInfo()
        {
            bool Result = false;
            string Username = txtTaiKhoan.Text.Trim();
            string Password = txtPassWord.Text.Trim();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var a = db.CUSTOMERs.Where(s => s.USERID == Username).SingleOrDefault();
            if (a != null)
            {
                Result = true;
            }

            return Result;
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
