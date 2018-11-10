using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class FindBillWithStatusDAO
    {
        private static FindBillWithStatusDAO instance;

        internal static FindBillWithStatusDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FindBillWithStatusDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private FindBillWithStatusDAO()
        {

        }
        public List<Bill> FindBillWithStatus(int idTable)
        {
            SaleModel db = new SaleModel();
            var ls = from x in db.Bills
                     where x.StatusInfo == 1 && x.idTable == idTable
                     select x;
            return ls.ToList();
        }
    }
}
