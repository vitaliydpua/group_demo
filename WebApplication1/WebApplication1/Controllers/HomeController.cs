using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        static List<string> items = new List<string>();
        public ActionResult Index()
        {
            return View("Hello world");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(items);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}