using DothanTech.BaoJia.IDAL;
using DothanTech.BaoJia.Module;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.EFDAL
{
    public class BaseDao<T> : IBaseDao<T> where T : class
    {
        private DbContext mDbContext = EFContextFactory.GetCurrentDbContext();

        public int GetCount(Expression<Func<T, bool>> exp)
        {
            return this.mDbContext.Set<T>().Where(exp).Count();
        }

        public T GetEntity(Expression<Func<T, bool>> exp)
        {
            IQueryable<T> entities = this.mDbContext.Set<T>().Where(exp);
            if (entities != null)
                return entities.SingleOrDefault();

            return null;
        }

        public IQueryable<T> GetEntities(Expression<Func<T, bool>> exp)
        {
            return this.mDbContext.Set<T>().Where(exp);
        }

        public bool Add(T t, bool saveChanged = true)
        {
            this.mDbContext.Set<T>().Add(t);
            if (saveChanged)
                return this.mDbContext.SaveChanges() > 0;

            return true;
        }

        public bool Delete(T t, bool saveChanged = true)
        {
            this.mDbContext.Set<T>().Attach(t);
            this.mDbContext.Entry<T>(t).State = System.Data.EntityState.Deleted;
            if (saveChanged)
                return this.mDbContext.SaveChanges() > 0;

            return true;
        }

        public bool Update(T t, bool saveChanged = true)
        {
            this.mDbContext.Set<T>().Attach(t);
            this.mDbContext.Entry<T>(t).State = System.Data.EntityState.Modified;
            if (saveChanged)
                return this.mDbContext.SaveChanges() > 0;

            return true;
        }
    }
}
