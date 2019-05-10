using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;
using System.Data.Entity.Migrations;
namespace MVCExample.Controllers
{
    public class LoginController : Controller
    {
        Database1Entities db = new Database1Entities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Register r)
        {
            TempData["uid"] = r.UserId;
            TempData.Keep();
            var s =(from c in db.Registers where c.UserId.Equals(r.UserId) && c.Pass.Equals(r.Pass) select c).FirstOrDefault();
            if(s!=null)
            {
                return RedirectToAction("../Student");
            }
            else
            {
                ViewBag.data = "Invalid userid and password";
            }
  
                
            return View();
        }
        public ActionResult Reg()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Reg(Register r)
        {
            
            var s = (from c in db.Registers where c.UserId.Equals(r.UserId) select c).FirstOrDefault();
            if (s == null)
            {
                db.Registers.Add(r);
                db.SaveChanges();
                ViewBag.Data = "Registration SuccessFully";
            }
            else
            {
                
               
               
                ViewBag.Data = "UserId is already exist";
            }

            return View();

        }

    }
}