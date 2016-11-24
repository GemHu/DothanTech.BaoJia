using DothanTech.BaoJia.BLL;
using DothanTech.BaoJia.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DothanTech.BaoJia.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // 品名
            IQueryable<Product> productList = new ProductService().GetEntities(o => true);
            if (productList != null)
                ViewBag.Products = productList.ToList<Product>();

            // 品牌
            IQueryable<Brand> brandList = new BrandService().GetEntities(o => true);
            if (brandList != null)
                ViewBag.Brands = brandList.ToList<Brand>();

            // 收货地区
            IQueryable<DeliveryArea> deliveryAreaList = new DeliveryAreaService().GetEntities(o => true);
            if (deliveryAreaList != null)
                ViewBag.DeliveryAreas = deliveryAreaList.ToList<DeliveryArea>();

            // 运输方式
            IQueryable<DeliveryMode> deliveryModeList = new DeliveryModeService().GetEntities(o => true);
            if (deliveryModeList != null)
                ViewBag.DeliveryModes = deliveryModeList.ToList<DeliveryMode>();

            // 工艺要求
            IQueryable<TechnologyRequest> technologyRequestList = new TechnologyRequestService().GetEntities(o => true);
            if (technologyRequestList != null)
                ViewBag.TechnologyRequests = technologyRequestList.ToList<TechnologyRequest>();
            
            // 是否含税
            List<String> taxList = new List<string>() { "是", "否"};
            ViewBag.TaxOrNot = taxList;

            // 颜色
            IQueryable<PrintColor> printColorList = new PrintColorService().GetEntities(o => true);
            if (printColorList != null)
                ViewBag.PrintColors = printColorList.ToList<PrintColor>();
            
            // 专色
            IQueryable<SpecialColor> specialColorList = new SpecialColorService().GetEntities(o => true);
            if (specialColorList != null)
                ViewBag.SpecialColors = specialColorList.ToList<SpecialColor>();

            // 后道
            IQueryable<BackChannel> backChannelList = new BackChannelService().GetEntities(o => true);
            if (backChannelList != null)
                ViewBag.BackChannels = backChannelList.ToList<BackChannel>();

            return View();
        }

        

    }
}
