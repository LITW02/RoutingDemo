using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;

namespace MvcApplication34.Controllers
{
    [RoutePrefix("stuff")]
    public class HomeController : Controller
    {
        [Route("bar")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("home/{category}/{id}")]
        public ActionResult ViewCategory(string category, int id)
        {
            ViewBag.Category = category;
            ViewBag.Id = id;
            return View();
        }

        [Route("home/{productName}")]
        public ActionResult ProductPage(string productName)
        {
            ViewBag.ProductName = productName;
            return View();
        }

        [Route("home/about")]
        public ActionResult About()
        {
            return View();
        }
    }
}
