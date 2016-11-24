//引进TT模板的命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DothanTech.BaoJia.IDAL;
using DothanTech.BaoJia.Module;

namespace DothanTech.BaoJia.BLL
{
    public partial class BackChannelService : BaseService<BackChannel>
    {
        public BackChannelService()
        {
            this.BackChannelDao = this.mDbSession.BackChannelDao;
        }

        public IBackChannelDao<BackChannel> BackChannelDao
        {
            get { return base.Dao as IBackChannelDao<BackChannel>; }
            set { base.Dao = value; }
        }
    }

    public partial class BrandService : BaseService<Brand>
    {
        public BrandService()
        {
            this.BrandDao = this.mDbSession.BrandDao;
        }

        public IBrandDao<Brand> BrandDao
        {
            get { return base.Dao as IBrandDao<Brand>; }
            set { base.Dao = value; }
        }
    }

    public partial class DeliveryAreaService : BaseService<DeliveryArea>
    {
        public DeliveryAreaService()
        {
            this.DeliveryAreaDao = this.mDbSession.DeliveryAreaDao;
        }

        public IDeliveryAreaDao<DeliveryArea> DeliveryAreaDao
        {
            get { return base.Dao as IDeliveryAreaDao<DeliveryArea>; }
            set { base.Dao = value; }
        }
    }

    public partial class DeliveryModeService : BaseService<DeliveryMode>
    {
        public DeliveryModeService()
        {
            this.DeliveryModeDao = this.mDbSession.DeliveryModeDao;
        }

        public IDeliveryModeDao<DeliveryMode> DeliveryModeDao
        {
            get { return base.Dao as IDeliveryModeDao<DeliveryMode>; }
            set { base.Dao = value; }
        }
    }

    public partial class PrintColorService : BaseService<PrintColor>
    {
        public PrintColorService()
        {
            this.PrintColorDao = this.mDbSession.PrintColorDao;
        }

        public IPrintColorDao<PrintColor> PrintColorDao
        {
            get { return base.Dao as IPrintColorDao<PrintColor>; }
            set { base.Dao = value; }
        }
    }

    public partial class ProductService : BaseService<Product>
    {
        public ProductService()
        {
            this.ProductDao = this.mDbSession.ProductDao;
        }

        public IProductDao<Product> ProductDao
        {
            get { return base.Dao as IProductDao<Product>; }
            set { base.Dao = value; }
        }
    }

    public partial class ProductModuleService : BaseService<ProductModule>
    {
        public ProductModuleService()
        {
            this.ProductModuleDao = this.mDbSession.ProductModuleDao;
        }

        public IProductModuleDao<ProductModule> ProductModuleDao
        {
            get { return base.Dao as IProductModuleDao<ProductModule>; }
            set { base.Dao = value; }
        }
    }

    public partial class RecommandTableService : BaseService<RecommandTable>
    {
        public RecommandTableService()
        {
            this.RecommandTableDao = this.mDbSession.RecommandTableDao;
        }

        public IRecommandTableDao<RecommandTable> RecommandTableDao
        {
            get { return base.Dao as IRecommandTableDao<RecommandTable>; }
            set { base.Dao = value; }
        }
    }

    public partial class SpecialColorService : BaseService<SpecialColor>
    {
        public SpecialColorService()
        {
            this.SpecialColorDao = this.mDbSession.SpecialColorDao;
        }

        public ISpecialColorDao<SpecialColor> SpecialColorDao
        {
            get { return base.Dao as ISpecialColorDao<SpecialColor>; }
            set { base.Dao = value; }
        }
    }

    public partial class TechnologyRequestService : BaseService<TechnologyRequest>
    {
        public TechnologyRequestService()
        {
            this.TechnologyRequestDao = this.mDbSession.TechnologyRequestDao;
        }

        public ITechnologyRequestDao<TechnologyRequest> TechnologyRequestDao
        {
            get { return base.Dao as ITechnologyRequestDao<TechnologyRequest>; }
            set { base.Dao = value; }
        }
    }

}
