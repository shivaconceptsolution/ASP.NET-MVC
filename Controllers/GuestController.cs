using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}