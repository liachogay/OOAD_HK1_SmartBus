using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBus.User
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtName.Text = "";
            txtIDBank.Text = "";
            cbHocSinh.Checked = false;
            txtXe.Text = "121";
        }

        private void BtnXemTram_Click(object sender, EventArgs e)
        {
            int SoXe = int.Parse(txtXe.Text);
            StationBus stationBus = new StationBus(SoXe);
            stationBus.ShowDialog();
        }
    }
}
