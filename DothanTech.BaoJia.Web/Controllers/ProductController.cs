using DothanTech.BaoJia.BLL;
using DothanTech.BaoJia.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DothanTech.BaoJia.Web.Controllers
{
    public class ProductController : Controller
    {
        public ProductService mService;

        public ProductController()
        {
            this.mService = new ProductService();
        }

    }
}
