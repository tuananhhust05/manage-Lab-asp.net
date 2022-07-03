using Model13.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model13
{
    public class AccountModel // phần này thực hiện các câu truy vấn 
    {
        private OnlineShopModelContext context = null;
        public AccountModel()  // contructor
        {
            context = new OnlineShopModelContext();
        }
        public bool login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",userName),
                 new SqlParameter("@password",password),
            };
            var res = context.Database.SqlQuery<bool>("webdatabase.dbo.Sp_Account_Login @UserName,@password", sqlParams).SingleOrDefault();
            return res;  // 1 số 1 hoặc 0
        }
    }
}
