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
        bool AddTable()
        {
            SaleModel db = new SaleModel();
            return true;
        }
    }
}
