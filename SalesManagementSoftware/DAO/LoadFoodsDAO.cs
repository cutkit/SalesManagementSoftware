using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class LoadFoodsDAO
    {
        private SaleModel db = new SaleModel();
        private static LoadFoodsDAO instance;

        internal static LoadFoodsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadFoodsDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LoadFoodsDAO()
        {

        }

        public List<Food> LoadFoods(int idTable)
        {
            List<Food> result= null;
            var ls = from x in db.TableCustomers
                     join y in db.Bills on x.Id equals  
            return result;
        }
    }
}
