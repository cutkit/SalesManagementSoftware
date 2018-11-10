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
        public bool AddFood(int idBill, int idFood,int countFood)
        {
            SaleModel db = new SaleModel();
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
            return false;
        }
    }
}
