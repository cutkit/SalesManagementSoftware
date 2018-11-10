using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class FindFoodIdDAO
    {
        private static FindFoodIdDAO instance;

        internal static FindFoodIdDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FindFoodIdDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private FindFoodIdDAO()
        {

        }
        public int FindFood(string nameFood)
        {
            SaleModel db = new SaleModel();
            var result = db.Foods.SingleOrDefault(x => x.FoodName == nameFood);
            return result.Id;
        }
    }
}
