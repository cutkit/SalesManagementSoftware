using SalesManagementSoftware.DAO;
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
            LoadTableDAO.
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
