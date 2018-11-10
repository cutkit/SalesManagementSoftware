using SalesManagementSoftware.DTO;
using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class AddFoodDAO
    {
        private static AddFoodDAO instance;

        internal static AddFoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddFoodDAO();
                }
                return instance;
            }
            set => instance = value;
        }
        public bool AddFood(int idTable, int idBill, int idFood,int countFood)
        {
            SaleModel db = new SaleModel();



            //var ls = from x in db.TableCustomers
            //         join y in db.Bills on x.Id equals y.idTable
            //         where y.StatusInfo == 1
            //         select y;
            List<FoodShowDTO> ls = LoadFoodsDAO.Instance.LoadFoods(idTable);

            if (ls == null)
            {
                Bill bill = new Bill();
                bill.idTable = idTable;
                bill.StatusInfo = 1;

                BillInfo billInfo = new BillInfo();
                billInfo.idFood = idFood;
                billInfo.CountFood = countFood;
                billInfo.idBill = bill.Id;
                BillInfo Info = db.BillInfoes.Add(billInfo);
                db.SaveChanges();
                if (Info != null)
                {
                    return true;
                }
            }
            else
            {
                BillInfo billInfo = new BillInfo();
                billInfo.idFood = idFood;
                billInfo.CountFood = countFood;
                billInfo.idBill = idBill;
                BillInfo Info = db.BillInfoes.Add(billInfo);
                db.SaveChanges();
                if (Info != null)
                {
                    return true;
                }
            }

            //Bill bill = db.Bills.SingleOrDefault(x => x.Id == idBill);
            //bill.StatusInfo = 1;
           
            return false;
        }
    }
}
