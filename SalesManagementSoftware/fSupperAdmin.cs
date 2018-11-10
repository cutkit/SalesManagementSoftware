using SalesManagementSoftware.DAO;
using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSoftware
{
    public partial class fSupperAdmin : Form
    {
        public fSupperAdmin()
        {
            InitializeComponent();
            LoadUser();
            LoadTable();
        }
        void LoadTable()
        {
            List<TableCustomer> tc = LoadTableAdminDAO.Instance.LoadTableAdmin();
            dgvTable.DataSource = tc;
        }
        void LoadUser()
        {
            string query = "UP_GetAccountByUserName @UserName";
            DataTable data = ProcedureDAO.Instance.ExcuteQuery(query, new object[] { "gotheap" });
            dtgvAccount.DataSource = data;
        }
        private void tbpFood_Click(object sender, EventArgs e)
        {

        }

        private void tpAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nmFoodPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbpDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void tbpCategory_Click(object sender, EventArgs e)
        {

        }

        private void tbpBan_Click(object sender, EventArgs e)
        {

        }

        private void tbpAccount_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpkToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {

        }

        private void txbSearchFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbFoodId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntAddTable_Click(object sender, EventArgs e)
        {
            fAddTableAdmin fAddTableAdmin = new fAddTableAdmin();
            fAddTableAdmin.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
