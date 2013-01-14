using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSES.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Red Squirrel Electrical Services";
            

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
