using SalesManagementSoftware.DTO;
using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class CreateBillDAO
    {
        private static CreateBillDAO instance;

        internal static CreateBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CreateBillDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private CreateBillDAO()
        {

        }
        public void CreateBill(int idTable)
        {
            //  List<FoodShowDTO> foods = LoadFoodsDAO.Instance.LoadFoods(idTable);
            SaleModel db = new SaleModel();
            //if (foods == null)
            //{
            Bill bill = new Bill();
            bill.idTable = idTable;
            bill.StatusInfo = 1;
            db.Bills.Add(bill);
           

            db.SaveChanges();
            
        }
        public int FindIdBill()
        {
            SaleModel db = new SaleModel();
            Bill bill2 = db.Bills.SingleOrDefault(x => x.StatusInfo == 1);
            return bill2.Id;
        }
      
    }
}
