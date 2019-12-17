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
            string Username = txtTaiKhoan.Text;
            string Password = txtPassWord.Text;
            string Name = txtPassWord.Text;
            int Age = int.Parse(txtTuoi.Text);
            if (Username.Length == 0 || Password.Length == 0||
                Name.Length == 0 || txtTuoi.Text.Length == 0)
            {
                Result = 2;
            }
            else if (Username.Length>0)
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
