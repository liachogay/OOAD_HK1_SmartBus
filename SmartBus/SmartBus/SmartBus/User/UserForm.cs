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
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(CUSTOMER customer)
        {
            InitializeComponent();
            txtAccount.Text = customer.USERID.ToString();
            txtName.Text = customer.NAMECUS.ToString();
            txtIDBank.Text = customer.BANKID.ToString();
            cbHocSinh.Checked = customer.ISSTUDENT;
            var Temp = db.TRACKERs.Where(s => s.USERNAMEID == customer.USERID).SingleOrDefault();
            if (Temp != null)
            {
                txtXe.Text = Temp.NUMBERBUSID.ToString();
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnXemTram_Click(object sender, EventArgs e)
        {
            if (txtXe.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa lên xe bus nên không thể xem trạm của xe", "Thông báo");
                return;
            }
            int SoXe = int.Parse(txtXe.Text);
            StationBus stationBus = new StationBus(SoXe);
            stationBus.ShowDialog();
        }
    }
}
