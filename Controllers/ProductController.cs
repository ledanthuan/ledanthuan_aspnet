using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeDanThuan_2122110052.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Listing_Grid()
        {
            return View();
        }
        public ActionResult Listing_Large()
        {
            return View();
        }

    }
}