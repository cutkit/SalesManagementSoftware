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
    public partial class fAddTableAdmin : Form
    {
        public fAddTableAdmin()
        {
            InitializeComponent();
        }

        private void fAddTableAdmin_Load(object sender, EventArgs e)
        {

        }
       

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string nameTable = txbTableName.Text;
            string status = txbStatus.Text;
            
            if (AddTableDAO.Instance.AddTable(nameTable, status))
            {
                MessageBox.Show("Thêm Thành Công!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
