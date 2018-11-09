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
    public partial class fTableManger : Form
    {
        public fTableManger()
        {
            InitializeComponent();
            LoadTable();
        }
        void LoadTable()
        {
            List<TableCustomer> table= LoadTableDAO.Instance.GetTable();
            foreach (TableCustomer item in table)
            {
                Button btn = new Button();
                btn.Height = 90;
                btn.Width = 90;
                btn.Text = item.NameTable + "\n" + item.StatusInfo;
                btn.Tag = item;
                btn.Click += Btn_Click;
                flpTable.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            List<Food> foods = LoadFoodsDAO(1);
            //throw new NotImplementedException();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccountProfile = new fAccountProfile();
            fAccountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSupperAdmin fSupperAdmin = new fSupperAdmin();
            fSupperAdmin.ShowDialog();
        }
    }
}
