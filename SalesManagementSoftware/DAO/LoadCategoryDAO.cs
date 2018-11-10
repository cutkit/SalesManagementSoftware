using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class LoadCategoryDAO
    {
        SaleModel db = new SaleModel();
        private static LoadCategoryDAO instance;

        internal static LoadCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadCategoryDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LoadCategoryDAO()
        {

        }
        public List<FoodCategory> LoadCategory()
        {
            var ls = from x in db.FoodCategories
                     select x;
            return ls.ToList();
        }
    }
}
