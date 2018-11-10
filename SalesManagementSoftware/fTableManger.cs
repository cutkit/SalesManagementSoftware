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
            List<TableCustomer> table = LoadTableDAO.Instance.GetTable();
            foreach (TableCustomer item in table)
            {
                if (item.StatusInfo =="Trống")
                {

                }
                Button btn = new Button();
                btn.Height = 90;
                btn.Width = 90;
                btn.Text = item.NameTable + "\n" + item.StatusInfo;
                btn.Tag = item;
                btn.Click += Btn_Click;
                if (item.StatusInfo == "Trống")
                {
                    btn.BackColor = Color.Azure;
                }
                else
                {
                    btn.BackColor = Color.BlueViolet;
                }
                flpTable.Controls.Add(btn);
            }
        }
        private float idBill = 0.77f;
        private int idTable = 0;
        private void Btn_Click(object sender, EventArgs e)
        {

            double result = 0;
            lsvBill.Items.Clear();
            Button button = sender as Button;
            TableCustomer table = button.Tag as TableCustomer;
            idTable = table.Id;
            lbCurrentTable.Text = table.NameTable.ToString();
            List<FoodShowDTO> foods = LoadFoodsDAO.Instance.LoadFoods(table.Id);
            List<Bill> bills = FindBillWithStatusDAO.Instance.FindBillWithStatus(idTable);

            if (bills.Count == 0)
            {
                CreateBillDAO.Instance.CreateBill(table.Id);
                List<Bill> bills2 = FindBillWithStatusDAO.Instance.FindBillWithStatus(idTable);
                MessageBox.Show("Bàn Trống!!");
                foreach (var item in bills2)
                {
                    idBill = item.Id;
                }
            }
          
            foreach (var item in foods)
            {
                idBill = item.Id;
                ListViewItem lisviewItems = lsvBill.Items.Add(item.FoodName.ToString());
                lisviewItems.SubItems.Add(item.PriceFood.ToString());
                lisviewItems.SubItems.Add(item.CountFood.ToString());
                lisviewItems.SubItems.Add((item.CountFood * item.PriceFood).ToString());
                result += item.CountFood * item.PriceFood;
            }
            CultureInfo info = CultureInfo.GetCultureInfo("vi-VN");
            tbResult.Text = result.ToString("#,###", info.NumberFormat) + " Đ";


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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            string fc = cbCategory.SelectedItem.ToString();

            if (fc != null)
            {
                cbFood.Items.Clear();
                List<Food> foods = LoadFoodOfCategoryDAO.Instance.LoadFoods(fc);
                foreach (var item in foods)
                {
                    cbFood.Items.Add(item.FoodName);
                }
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cbFood.SelectedItem != null)
            {
                int count = (int)nmFoodCount.Value;
                int idFood = FindFoodIdDAO.Instance.FindFood(cbFood.SelectedItem.ToString());
                if (idBill != 0.77f)
                {

                    if (AddFoodDAO.Instance.AddFood(idTable, (int)idBill, idFood, count))
                    {
                        MessageBox.Show("Thêm Thành Công!!");
                    }
                    else
                    {
                        MessageBox.Show("Không Thêm Được!!");
                    }
                }
                lsvBill.Items.Clear();
                double result = 0;
                List<FoodShowDTO> foods = LoadFoodsDAO.Instance.LoadFoods(idTable);
                foreach (var item in foods)
                {
                    idBill = item.Id;
                    ListViewItem lisviewItems = lsvBill.Items.Add(item.FoodName.ToString());
                    lisviewItems.SubItems.Add(item.PriceFood.ToString());
                    lisviewItems.SubItems.Add(item.CountFood.ToString());
                    lisviewItems.SubItems.Add((item.CountFood * item.PriceFood).ToString());
                    result += item.CountFood * item.PriceFood;
                }
                CultureInfo info = CultureInfo.GetCultureInfo("vi-VN");
                tbResult.Text = result.ToString("#,###", info.NumberFormat) + " Đ";
            }
            else
            {
                MessageBox.Show("Xin Chọn Thức Ăn");
            }
        }
    }
}
