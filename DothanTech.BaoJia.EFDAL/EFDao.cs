//引进TT模板的命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DothanTech.BaoJia.IDAL;
using DothanTech.BaoJia.Module;

namespace DothanTech.BaoJia.EFDAL
{
    public partial class BackChannelDao : BaseDao<BackChannel>, IBackChannelDao<BackChannel>
    {
    }

    public partial class BrandDao : BaseDao<Brand>, IBrandDao<Brand>
    {
    }

    public partial class DeliveryAreaDao : BaseDao<DeliveryArea>, IDeliveryAreaDao<DeliveryArea>
    {
    }

    public partial class DeliveryModeDao : BaseDao<DeliveryMode>, IDeliveryModeDao<DeliveryMode>
    {
    }

    public partial class PrintColorDao : BaseDao<PrintColor>, IPrintColorDao<PrintColor>
    {
    }

    public partial class ProductDao : BaseDao<Product>, IProductDao<Product>
    {
    }

    public partial class ProductModuleDao : BaseDao<ProductModule>, IProductModuleDao<ProductModule>
    {
    }

    public partial class RecommandTableDao : BaseDao<RecommandTable>, IRecommandTableDao<RecommandTable>
    {
    }

    public partial class SpecialColorDao : BaseDao<SpecialColor>, ISpecialColorDao<SpecialColor>
    {
    }

    public partial class TechnologyRequestDao : BaseDao<TechnologyRequest>, ITechnologyRequestDao<TechnologyRequest>
    {
    }

}
