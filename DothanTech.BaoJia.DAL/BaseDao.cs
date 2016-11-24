using DothanTech.BaoJia.Module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.DAL
{
    public class BaseRepository<T> where T : class
    {
        //获取的是当前线程内部的上下文实例，而且保证了线程内上下文唯一
        private DbContext dbContext = EFContextFactory.GetCurrentDbContext();

        // 增
        public bool AddEntity(T entity, bool saveChanged)
        {
            this.dbContext.Set<T>().Attach(entity);
            this.dbContext.Entry<T>(entity).State = EntityState.Added;

            if (saveChanged)
                return this.SaveChanged() > 0;

            return true;
        }

        // 删
        public bool DeleteEntity(T entity, bool saveChanged = false)
        {
            this.dbContext.Set<T>().Attach(entity);
            this.dbContext.Entry<T>(entity).State = EntityState.Deleted;

            if (saveChanged)
                return this.SaveChanged() > 0;

            return true;
        }

        // 查

        public IQueryable<T> GetEntity()
        {
            return this.dbContext.Set<T>();
        }

        public IQueryable<T> GetEntity(Expression<Func<T, bool>> predicate)
        {
            return this.dbContext.Set<T>().Where(predicate);
        }

        // 改
        public bool UpdateEntity(T entity, bool saveChanged = false)
        {
            this.dbContext.Set<T>().Attach(entity);
            this.dbContext.Entry<T>(entity).State = EntityState.Modified;

            if (saveChanged)
                return this.SaveChanged() > 0;

            return true;
        }

        public int SaveChanged()
        {
            return this.dbContext.SaveChanges();
        }
    }
}
