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
    public partial class BusForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public BusForm()
        {
            InitializeComponent();
        }

        private void BusForm_Load(object sender, EventArgs e)
        {
            txtIDBus.ReadOnly = true;
            txtChair.ReadOnly = true;

            DataGridViewTextBoxColumn dgvTK = new DataGridViewTextBoxColumn();
            dgvTK.HeaderText = "Mã xe";
            DataGridViewTextBoxColumn dgvcMX = new DataGridViewTextBoxColumn();
            dgvcMX.HeaderText = "Số ghế trên xe";


            dataGridView2.Columns.Add(dgvTK);
            dataGridView2.Columns.Add(dgvcMX);
            InitData();

        }

        private void InitData()
        {
            dataGridView2.Rows.Clear();
            var Temp = from bus in db.BUS select bus;
            foreach (var item in Temp)
            {
                dataGridView2.Rows.Add(item.BUSID, item.NUMBERCHAIRBUS);
            }

            dataGridView2.AllowUserToAddRows = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtIDBus.ReadOnly = false;
            txtChair.ReadOnly = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var Temp = from bus in db.BUS
                       where bus.BUSID == int.Parse(txtIDBus.Text.Trim())
                       select bus;
            foreach (var item in Temp)
            {
                db.BUS.DeleteOnSubmit(item);
            }
            db.SubmitChanges();
            InitData();
            MessageBox.Show("Xóa thành công", "Thông báo");

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtIDBus.ReadOnly = true;
            txtChair.ReadOnly = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            if (txtIDBus.Text == string.Empty) return;
            int idBus = int.Parse(txtIDBus.Text.Trim());
            var Temp = db.BUS.Where(s => s.BUSID == idBus).SingleOrDefault();
            if (Temp != null)
            {
                Temp.NUMBERCHAIRBUS = (txtChair.Text.Trim() == string.Empty) ? 0 : int.Parse(txtChair.Text.Trim());
                db.SubmitChanges();
                InitData();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                BUS a = new BUS();
                a.BUSID = int.Parse(txtIDBus.Text.Trim());
                a.NUMBERCHAIRBUS = (txtChair.Text.Trim() == string.Empty) ? 0 : int.Parse(txtChair.Text.Trim());
                db.BUS.InsertOnSubmit(a);
                db.SubmitChanges();
                InitData();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            txtIDBus.ReadOnly = true;
            txtChair.ReadOnly = true;
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBus.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtChair.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
