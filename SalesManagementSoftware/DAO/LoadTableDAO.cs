using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class LoadTableDAO
    {
        SaleModel db = new SaleModel();
        private static LoadTableDAO instance;

        internal static LoadTableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadTableDAO();
                }
                return instance;
            }
            set => instance = value;
        }
        private LoadTableDAO()
        {

        }
        internal List<TableCustomer> GetTable()
        {
            var sl = from x in db.TableCustomers select x;
            List<TableCustomer> reulst = sl.ToList();
            return reulst;
        }
    }
}
