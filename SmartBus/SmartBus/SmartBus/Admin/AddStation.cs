using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBus.Admin
{
    public partial class AddStation : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public AddStation()
        {
            InitializeComponent();
        }

        private void AddStation_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn dgvIDSta = new DataGridViewTextBoxColumn();
            dgvIDSta.HeaderText = "Trạm số";
            DataGridViewTextBoxColumn dgvcIDBus = new DataGridViewTextBoxColumn();
            dgvcIDBus.HeaderText = "Mã xe";
            DataGridViewTextBoxColumn dgvcAddres = new DataGridViewTextBoxColumn();
            dgvcAddres.HeaderText = "Địa chỉ";


            dataGridView2.Columns.Add(dgvIDSta);
            dataGridView2.Columns.Add(dgvcIDBus);
            dataGridView2.Columns.Add(dgvcAddres);
            InitData();
            txtIDSta.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtAddress.ReadOnly = true;
        }

        private void InitData()
        {
            dataGridView2.Rows.Clear();
            var Temp = from sta in db.STATIONBUS select sta;
            foreach (var item in Temp)
            {
                dataGridView2.Rows.Add(item.NUMBERSTATION, item.BUSID,item.ADDRESSSTATION);
            }

            dataGridView2.AllowUserToAddRows = false;
        }
    

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtIDSta.ReadOnly = false;
            txtIDBus.ReadOnly = false;
            txtAddress.ReadOnly = false;

            txtIDSta.Clear();
            txtIDBus.Clear();
            txtAddress.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtIDSta.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtAddress.ReadOnly = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;


            if (txtIDBus.Text == string.Empty) return;
            int idBus = int.Parse(txtIDBus.Text.Trim());
            int idStation = int.Parse(txtIDSta.Text.Trim());
            var Temp = db.STATIONBUS.Where(s => s.BUSID == idBus && s.NUMBERSTATION == idStation).SingleOrDefault();
            if (Temp != null)
            {
                Temp.ADDRESSSTATION = txtAddress.Text.Trim();
                db.SubmitChanges();
                InitData();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                STATIONBUS a = new STATIONBUS();
                a.BUSID = int.Parse(txtIDBus.Text.Trim());
                a.NUMBERSTATION = int.Parse(txtIDSta.Text.Trim());
                a.ADDRESSSTATION = txtAddress.Text.Trim();
                db.STATIONBUS.InsertOnSubmit(a);
                db.SubmitChanges();
                InitData();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }

            txtIDSta.ReadOnly = true;
            txtIDBus.ReadOnly = true;
            txtAddress.ReadOnly = true;



        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDSta.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIDBus.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
