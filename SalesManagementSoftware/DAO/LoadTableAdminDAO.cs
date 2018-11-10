using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class LoadTableAdminDAO
    {
        private static LoadTableAdminDAO instance;

        internal static LoadTableAdminDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadTableAdminDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LoadTableAdminDAO()
        {

        }
        public List<TableCustomer> LoadTableAdmin()
        {
            SaleModel db = new SaleModel();
            var ls = from x in db.TableCustomers
                     select x;
            return ls.ToList();

        }
    }
}
