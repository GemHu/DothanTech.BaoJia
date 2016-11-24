using DothanTech.BaoJia.BLL;
using DothanTech.BaoJia.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DothanTech.BaoJia.Web.Controllers
{
    public class ProductModuleController : Controller
    {
        //
        // GET: /ProductModule/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetListByBrandId(String id)
        {
            ProductModuleService service = new ProductModuleService();
            List<ProductModule> items = service.GetListByBrandId(id);
            StringBuilder builder = new StringBuilder();

            if (items != null && items.Count > 0)
            {
                foreach(ProductModule item in items)
                {
                    builder.AppendFormat("<option value='{0}'>{1}</option>", item.Id, item.ModuleName);
                }
            }

            return Json(builder.ToString(), JsonRequestBehavior.AllowGet);
        }
    }
}
