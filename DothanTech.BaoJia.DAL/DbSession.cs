using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.DAL
{
    /// <summary>
    /// 应用程序跟数据库之间的一次会话，也是数据库访问层的统一入口。
    /// </summary>
    public class DbSession
    {
        #region 数据库表对应的数据访问层接口。
        // 这部分代码可以通过T4模板自动生成。
        // 或者通过Spring的依赖注入的方式直接注入到相关的类中。

        public ProductDao ProductDao
        {
            get { return this._ProductDao == null ? new ProductDao() : this._ProductDao; }
        }
        private ProductDao _ProductDao;

        public BrandDao BrandDao 
        {
            get { return this._BrandDao != null ? this._BrandDao : new BrandDao(); } 
        }
        private BrandDao _BrandDao;

        public ProductModuleDao ProductModuleDao
        {
            get { return this._ProductModuleDao != null ? this._ProductModuleDao : new ProductModuleDao(); }
        }
        private ProductModuleDao _ProductModuleDao;

        #endregion
    }
}
