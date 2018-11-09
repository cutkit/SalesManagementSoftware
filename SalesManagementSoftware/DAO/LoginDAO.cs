using SalesManagementSoftware.EntityFW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class LoginDAO
    {
        SaleModel db = new SaleModel();
        private static LoginDAO instance;

        internal static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LoginDAO()
        {

        }
        internal bool LoginCheck(string userName, string pw)
        {
            List<Account> log = db.Accounts.Where(x => x.UserName == userName && x.UserPassword == pw).ToList();
            if (log.Count >0)
            {
                return true;
            }
            return false;
        }
    }
}
