using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCExample.Models;
namespace MVCExample.Controllers
{
    public class DeptEmpController : Controller
    {
        Database1Entities db = new Database1Entities();

        // GET: DeptEmp
        public ActionResult Index()
        {
            // var s = db.Emps.Include(a => a.Dept).Where(a=>a.Dept.Deptname=="HR");
            var s1 = from c in db.Emps from d in db.Depts where c.DeptId == d.DeptId && d.Deptname=="HR" select new { empname = c.EmpName, deptname = d.Deptname };
            var s = from c in db.Emps join d in db.Depts on c.DeptId equals d.DeptId where d.Deptname == "HR" select new DeptEmp{ em =c,dep=d};
            return View(s);
        }
    }
}