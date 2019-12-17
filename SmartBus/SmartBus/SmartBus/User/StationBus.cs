using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartBus.User
{
    public partial class StationBus : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public StationBus(int soXe)
        {
            InitializeComponent();
            lbHeader.Text += soXe.ToString();

            DataGridViewTextBoxColumn a = new DataGridViewTextBoxColumn();
            a.HeaderText = "Trạm số";
            DataGridViewTextBoxColumn b = new DataGridViewTextBoxColumn();
            b.HeaderText = "Mã xe bus";
            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.HeaderText = "Địa chỉ";


            dgvTram.Columns.Add(a);
            dgvTram.Columns.Add(b);
            dgvTram.Columns.Add(c);
            InitData();
        }

        private void InitData()
        {
            dgvTram.Rows.Clear();
            var Temp = from stabus in db.STATIONBUS select stabus;
            foreach (var item in Temp)
            {
                dgvTram.Rows.Add(item.NUMBERSTATION, item.BUSID, item.ADDRESSSTATION);
            }

            dgvTram.AllowUserToAddRows = false;
        }
    }
}
