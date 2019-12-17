using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartBus.Tracker
{
    public partial class TrackerForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public TrackerForm()
        {
            InitializeComponent();
        }

        private void TrackerForm_Load(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn dgvTK = new DataGridViewTextBoxColumn();
            dgvTK.HeaderText = "Tài khoản";
            DataGridViewTextBoxColumn dgvcMX = new DataGridViewTextBoxColumn();
            dgvcMX.HeaderText = "Mã xe";
            DataGridViewTextBoxColumn dgvcTL = new DataGridViewTextBoxColumn();
            dgvcTL.HeaderText = "Trạm lên";
            DataGridViewTextBoxColumn dgvcTX = new DataGridViewTextBoxColumn();
            dgvcTX.HeaderText = "Trạm xuống";


            dgvTracker.Columns.Add(dgvTK);
            dgvTracker.Columns.Add(dgvcMX);
            dgvTracker.Columns.Add(dgvcTL);
            dgvTracker.Columns.Add(dgvcTX);


            txtAccount.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtStationGoOn.ReadOnly = true;
            txtStationGoOut.ReadOnly = true;

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            InitData();
        }

        private void InitData()
        {
            var Temp = from a in db.TRACKERs select a;
            foreach(var item in Temp)
            {
                dgvTracker.Rows.Add(item.USERNAMEID, item.NUMBERBUSID, item.POSTIONBUSUP, item.POSTIONBUSDOWN);
            }

            dgvTracker.AllowUserToAddRows = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtAccount.ReadOnly = false;
            txtIDBus.ReadOnly = false;
            txtStationGoOn.ReadOnly = false;
            txtStationGoOut.ReadOnly = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            if (txtStationGoOn.Text != null && txtStationGoOut.Text != null)
            {

            }
            else
            {
                MessageBox.Show("Bạn không thể xóa thông tin khách chưa xuống xe");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtAccount.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtStationGoOn.ReadOnly = true;
            txtStationGoOut.ReadOnly = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtAccount.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtStationGoOn.ReadOnly = true;
            txtStationGoOut.ReadOnly = true;
        }
    }
}
