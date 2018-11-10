using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class LoadFoodOfCategoryDAO
    {
        private SaleModel db = new SaleModel();
        private static LoadFoodOfCategoryDAO instance;

        internal static LoadFoodOfCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadFoodOfCategoryDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LoadFoodOfCategoryDAO()
        {

        }
        public List<Food> LoadFoods(string nameCategoryFood)
        {
            var ls = from x in db.FoodCategories
                     join y in db.Foods on x.Id equals y.IdCategory
                     where x.NameCategory == nameCategoryFood
                     select y;
            return ls.ToList();
        }
    }
}
