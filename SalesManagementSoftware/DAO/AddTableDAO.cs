using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class AddTableDAO
    {
        private static AddTableDAO instance;

        internal static AddTableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AddTableDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private AddTableDAO()
        {

        }
        public bool AddTable(string nameTable, string status)
        {
            SaleModel db = new SaleModel();
            TableCustomer tableCustomer = new TableCustomer();
            tableCustomer.NameTable = nameTable;
            tableCustomer.StatusInfo = status;
            TableCustomer info = db.TableCustomers.Add(tableCustomer);
            db.SaveChanges();
            if (info != null)
            {
                return true;
            }
            return false;
        }
    }
}
