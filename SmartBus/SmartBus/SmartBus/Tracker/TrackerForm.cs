using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartBus.Tracker
{
    public partial class TrackerForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        bool Add = false;
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
            dgvTracker.Rows.Clear();
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
            Add = true;
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

            var Temp = db.TRACKERs.Where(s => s.USERNAMEID == txtAccount.Text.Trim() &&
                                               s.NUMBERBUSID == int.Parse(txtIDBus.Text.Trim())).SingleOrDefault();
            if (Temp == null && Add)
            {
                TRACKER tracker = new TRACKER();
                tracker.NUMBERBUSID = int.Parse(txtIDBus.Text.Trim());
                tracker.USERNAMEID = txtAccount.Text.Trim();
                tracker.POSTIONBUSUP = int.Parse(txtStationGoOn.Text.Trim());
                tracker.POSTIONBUSDOWN = (txtStationGoOut.Text.Trim() == string.Empty) ? -1 : int.Parse(txtStationGoOut.Text.Trim());
                db.TRACKERs.Append(tracker);
                db.SubmitChanges();
                InitData();
                MessageBox.Show("Lên xe thành công", "Thông báo");

            }
            else if (Temp != null && Add)
            {
                MessageBox.Show("Quý khách chưa thanh toán chuyến xe trước", "Thông báo");
            }
            else if (!Add)
            {
                Temp.POSTIONBUSDOWN = int.Parse(txtStationGoOut.Text.Trim());
                db.SubmitChanges();
                InitData();
                MessageBox.Show("Xuống xe thành công", "Thông báo");
            }

            txtAccount.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtStationGoOn.ReadOnly = true;
            txtStationGoOut.ReadOnly = true;
            Add = false;
        }

        private void DgvTracker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccount.Text = dgvTracker.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIDBus.Text = dgvTracker.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStationGoOn.Text = dgvTracker.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStationGoOut.Text = dgvTracker.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
