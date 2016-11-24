using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.DAL
{
    public class DbSessionFactory
    {
        private static const String DB_SESSION = "DbSession";

        public static DbSession GetCurrentDbSession()
        {
            DbSession dbSession = CallContext.GetData(DB_SESSION) as DbSession;
            if (dbSession == null)
            {
                dbSession = new DbSession();
                CallContext.SetData(DB_SESSION, dbSession);
            }

            return dbSession;
        }
    }
}
