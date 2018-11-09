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
    public partial class fLogin : Form
    {
        SaleModel con = new SaleModel();
        public fLogin()
        {
            InitializeComponent();
        }


        #region Methods
        bool CheckLogin()
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            return LoginDAO.Instance.LoginCheck(userName, passWord);
            
        }
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            fTableManger fTableManger = new fTableManger();
            this.Hide();
            int show = 0;
            if (CheckLogin())
            {
                fTableManger.ShowDialog();
                show = 1;
            }
            if (show ==0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Xin đăng nhập lại!", "Cảnh báo đăng nhập");
            }
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Chắc chắn muốn thoát!? ","Thông Báo",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
