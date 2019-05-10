using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class EmpsController : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: Emps
        public ActionResult Index()
        {
            var emps = db.Emps.Include(e => e.Dept);
            return View(emps.ToList());
        }

        // GET: Emps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "Deptname");
            return View();
        }

        // POST: Emps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpId,EmpName,Job,Salary,DeptId")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Emps.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "Deptname", emp.DeptId);
            return View(emp);
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "Deptname", emp.DeptId);
            return View(emp);
        }

        // POST: Emps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,EmpName,Job,Salary,DeptId")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptId = new SelectList(db.Depts, "DeptId", "Deptname", emp.DeptId);
            return View(emp);
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emp emp = db.Emps.Find(id);
            db.Emps.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
