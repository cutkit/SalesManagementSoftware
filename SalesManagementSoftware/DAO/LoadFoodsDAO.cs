using SalesManagementSoftware.DTO;
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

        public List<FoodShowDTO> LoadFoods(int idTable)
        {

            var ls = from x in db.TableCustomers
                     join y in db.Bills on x.Id equals y.idTable
                     join z in db.BillInfoes on y.Id equals z.idBill
                     join t in db.Foods on z.idFood equals t.Id
                     where x.Id == idTable && y.StatusInfo == 1
                     select new FoodShowDTO() { Id = y.Id, FoodName = t.FoodName, PriceFood = t.PriceFood, CountFood = z.CountFood };
            return ls.ToList<FoodShowDTO>();
        }
    }
}
