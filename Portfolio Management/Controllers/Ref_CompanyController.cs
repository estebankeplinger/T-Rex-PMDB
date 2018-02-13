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
    public class Ref_CompanyController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Company
        public ActionResult Index()
        {
            return View(db.Ref_Companies.ToList());
        }

        // GET: Ref_Company/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Company ref_Company = db.Ref_Companies.Find(id);
            if (ref_Company == null)
            {
                return HttpNotFound();
            }
            return View(ref_Company);
        }

        // GET: Ref_Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ref_Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Company")] Ref_Company ref_Company)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Companies.Add(ref_Company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ref_Company);
        }

        // GET: Ref_Company/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Company ref_Company = db.Ref_Companies.Find(id);
            if (ref_Company == null)
            {
                return HttpNotFound();
            }
            return View(ref_Company);
        }

        // POST: Ref_Company/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Company")] Ref_Company ref_Company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Company).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ref_Company);
        }

        // GET: Ref_Company/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Company ref_Company = db.Ref_Companies.Find(id);
            if (ref_Company == null)
            {
                return HttpNotFound();
            }
            return View(ref_Company);
        }

        // POST: Ref_Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Company ref_Company = db.Ref_Companies.Find(id);
            db.Ref_Companies.Remove(ref_Company);
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
