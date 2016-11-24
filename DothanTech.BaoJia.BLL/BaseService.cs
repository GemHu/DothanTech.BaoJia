using DothanTech.BaoJia.EFDAL;
using DothanTech.BaoJia.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.BLL
{
    public class BaseService<T> where T : class
    {
        protected DbSession mDbSession;

        public BaseService()
        {
            this.mDbSession = DbSessionFactory.GetCurrentDbSession();
        }

        protected IBaseDao<T> Dao
        {
            get;
            set;
        }

        /// <summary>
        /// 获取实体的个数。
        /// </summary>
        public int GetCount(Expression<Func<T, bool>> exp)
        {
            if (this.Dao == null)
                return 0;

            return this.Dao.GetCount(exp);
        }

        public T GetEntity(Expression<Func<T, bool>> exp)
        {
            if (this.Dao == null)
                return null;

            return this.Dao.GetEntity(exp);
        }

        public IQueryable<T> GetEntities(Expression<Func<T, bool>> exp)
        {
            if (this.Dao == null)
                return null;

            return this.Dao.GetEntities(exp);
        }

        public bool Add(T t)
        {
            if (this.Dao == null)
                return false;

            return this.Dao.Add(t);
        }

        public bool Delete(T t)
        {
            if (this.Dao == null)
                return false;

            return this.Dao.Delete(t);
        }

        public bool Update(T t)
        {
            if (this.Dao == null)
                return false;

            return this.Dao.Update(t);
        }
    }
}
