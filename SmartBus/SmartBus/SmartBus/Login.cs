using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBus.Model;

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

            return Result;
        }

        private void InitData()
        {
            DBMemberDataContext db = new DBMemberDataContext();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
