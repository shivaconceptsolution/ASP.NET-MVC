using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            ViewData["a"] = 100;
            ViewBag.a = 100;
            TempData["a"] = 700+100;
            TempData.Keep();
            return RedirectToAction("About");
            //return View();
        }
        public ActionResult About()
        {
            TempData.Keep();
            return View();
        }
        

    }
}