using DothanTech.BaoJia.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DothanTech.BaoJia.BLL
{
    public partial class ProductModuleService
    {
        public List<ProductModule> GetListByBrandId(string id)
        {
            if (String.IsNullOrEmpty(id))
                return null;

            int brandId = Convert.ToInt32(id);
            return this.Dao.GetEntities(o => o.BrandId == brandId).ToList<ProductModule>();
        }

        public List<ProductModule> GetListByBrandName(String brandName)
        {
            if (String.IsNullOrEmpty(brandName))
                return null;

            return this.Dao.GetEntities(o => o.Brand != null && brandName.Equals(o.Brand.BrandName)).ToList<ProductModule>();
        }
    }
}
