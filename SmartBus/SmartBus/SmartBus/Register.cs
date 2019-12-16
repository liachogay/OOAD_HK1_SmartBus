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
            //
            int Result = 0; 
            string Username = txtTaiKhoan.Text;
            string Password = txtPassWord.Text;
            string Name = txtPassWord.Text;
            int Age = int.Parse(txtTuoi.Text);
            if (Username.Length == 0 || Password.Length == 0||
                Name.Length == 0 || txtTuoi.Text.Length == 0)
            {
                Result = 2;
            }
            if (Username.Length>0)
            {
                Result = true;
            }
            return Result;
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {

            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại","Lỗi");
            }
        }
    }
}
