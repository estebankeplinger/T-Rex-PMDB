using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;

namespace Portfolio_Management.Controllers
{
    public class Ref_RoleController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Role
        public ActionResult Index()
        {
            return View(db.Ref_Roles.ToList());
        }

        // GET: Ref_Role/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Role ref_Role = db.Ref_Roles.Find(id);
            if (ref_Role == null)
            {
                return HttpNotFound();
            }
            return View(ref_Role);
        }

        // GET: Ref_Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ref_Role/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Role")] Ref_Role ref_Role)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Roles.Add(ref_Role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ref_Role);
        }

        // GET: Ref_Role/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Role ref_Role = db.Ref_Roles.Find(id);
            if (ref_Role == null)
            {
                return HttpNotFound();
            }
            return View(ref_Role);
        }

        // POST: Ref_Role/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Role")] Ref_Role ref_Role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ref_Role);
        }

        // GET: Ref_Role/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Role ref_Role = db.Ref_Roles.Find(id);
            if (ref_Role == null)
            {
                return HttpNotFound();
            }
            return View(ref_Role);
        }

        // POST: Ref_Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Role ref_Role = db.Ref_Roles.Find(id);
            db.Ref_Roles.Remove(ref_Role);
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
