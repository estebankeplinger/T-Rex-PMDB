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
    public class Ref_CustomerController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Customer
        public ActionResult Index()
        {
            var ref_Customers = db.Ref_Customers.Include(r => r.Adm_Agency);
            return View(ref_Customers.ToList());
        }

        // GET: Ref_Customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Customer ref_Customer = db.Ref_Customers.Find(id);
            if (ref_Customer == null)
            {
                return HttpNotFound();
            }
            return View(ref_Customer);
        }

        // GET: Ref_Customer/Create
        public ActionResult Create()
        {
            ViewBag.Agency_ID = new SelectList(db.Adm_Agencies, "ID", "Agency");
            return View();
        }

        // POST: Ref_Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Customer,Agency_ID")] Ref_Customer ref_Customer)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Customers.Add(ref_Customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Agency_ID = new SelectList(db.Adm_Agencies, "ID", "Agency", ref_Customer.Agency_ID);
            return View(ref_Customer);
        }

        // GET: Ref_Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Customer ref_Customer = db.Ref_Customers.Find(id);
            if (ref_Customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.Agency_ID = new SelectList(db.Adm_Agencies, "ID", "Agency", ref_Customer.Agency_ID);
            return View(ref_Customer);
        }

        // POST: Ref_Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Customer,Agency_ID")] Ref_Customer ref_Customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Agency_ID = new SelectList(db.Adm_Agencies, "ID", "Agency", ref_Customer.Agency_ID);
            return View(ref_Customer);
        }

        // GET: Ref_Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Customer ref_Customer = db.Ref_Customers.Find(id);
            if (ref_Customer == null)
            {
                return HttpNotFound();
            }
            return View(ref_Customer);
        }

        // POST: Ref_Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Customer ref_Customer = db.Ref_Customers.Find(id);
            db.Ref_Customers.Remove(ref_Customer);
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
