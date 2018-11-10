using SalesManagementSoftware.DAO;
using SalesManagementSoftware.DTO;
using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            LoadCategory();
        }
        void LoadCategory()
        {
            List<FoodCategory> fc = LoadCategoryDAO.Instance.LoadCategory();
            foreach (var item in fc)
            {
                cbCategory.Items.Add(item.NameCategory);
            }
                
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
            double result = 0;
            lsvBill.Items.Clear();
            Button button = sender as Button;
            TableCustomer table = button.Tag as TableCustomer;
            List<FoodShowDTO> foods = LoadFoodsDAO.Instance.LoadFoods(table.Id);
            foreach (var item in foods)
            {
                ListViewItem lisviewItems = lsvBill.Items.Add(item.FoodName.ToString());
                lisviewItems.SubItems.Add(item.PriceFood.ToString());
                lisviewItems.SubItems.Add(item.CountFood.ToString());
                lisviewItems.SubItems.Add((item.CountFood * item.PriceFood).ToString());
                result += item.CountFood * item.PriceFood;
            }
            CultureInfo info = CultureInfo.GetCultureInfo("vi-VN");
            tbResult.Text = result.ToString("#,###",info.NumberFormat) + " Đ";
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

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
