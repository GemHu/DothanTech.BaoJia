using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.IDAL
{
    public interface IBaseDao<T>
    {
        /// <summary>
        /// 获取记录数
        /// </summary>
        int GetCount(Expression<Func<T, bool>> exp);

        /// <summary>
        /// 获取Entitiy（单个）
        /// </summary>
        T GetEntity(Expression<Func<T, bool>> exp);

        /// <summary>
        /// 获取Entities（列表）
        /// </summary>
        IQueryable<T> GetEntities(Expression<Func<T, bool>> exp);

        /// <summary>
        /// 新增Entity
        /// </summary>
        bool Add(T t, bool saveChanged = true);

        /// <summary>
        /// 删除Entity
        /// </summary>
        bool Delete(T t, bool saveChanged = true);

        /// <summary>
        /// 更新Entity
        /// </summary>
        bool Update(T t, bool saveChanged = true);
    }
}
