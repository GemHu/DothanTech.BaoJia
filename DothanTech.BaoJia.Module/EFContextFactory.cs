using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.Module
{
    public class EFContextFactory
    {
        private const String DB_CONTEXT = "DbContext";

        //帮我们返回当前线程内的数据库上下文，如果当前线程内没有上下文，那么创建一个上下文，并保证
        //上线问实例在线程内部是唯一的
        public static DbContext GetCurrentDbContext()
        {
            //线程在数据槽里面没有此上下文
            DbContext dbContext = CallContext.GetData(DB_CONTEXT) as DbContext;
            if (dbContext == null)
            {
                dbContext = new BaoJia.Module.BaoJiaEntities();
                CallContext.SetData(DB_CONTEXT, dbContext);
            }

            return dbContext;
        }
    }
}
