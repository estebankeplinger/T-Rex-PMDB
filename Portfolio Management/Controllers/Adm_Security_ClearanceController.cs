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
    public class Adm_Security_ClearanceController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Security_Clearance
        public ActionResult Index()
        {
            return View(db.Adm_Security_Clearances.ToList());
        }

        // GET: Adm_Security_Clearance/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Security_Clearance adm_Security_Clearance = db.Adm_Security_Clearances.Find(id);
            if (adm_Security_Clearance == null)
            {
                return HttpNotFound();
            }
            return View(adm_Security_Clearance);
        }

        // GET: Adm_Security_Clearance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Security_Clearance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Security_Clearance,Security_Clearance_Abbreviation")] Adm_Security_Clearance adm_Security_Clearance)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Security_Clearances.Add(adm_Security_Clearance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Security_Clearance);
        }

        // GET: Adm_Security_Clearance/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Security_Clearance adm_Security_Clearance = db.Adm_Security_Clearances.Find(id);
            if (adm_Security_Clearance == null)
            {
                return HttpNotFound();
            }
            return View(adm_Security_Clearance);
        }

        // POST: Adm_Security_Clearance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Security_Clearance,Security_Clearance_Abbreviation")] Adm_Security_Clearance adm_Security_Clearance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Security_Clearance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Security_Clearance);
        }

        // GET: Adm_Security_Clearance/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Security_Clearance adm_Security_Clearance = db.Adm_Security_Clearances.Find(id);
            if (adm_Security_Clearance == null)
            {
                return HttpNotFound();
            }
            return View(adm_Security_Clearance);
        }

        // POST: Adm_Security_Clearance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Security_Clearance adm_Security_Clearance = db.Adm_Security_Clearances.Find(id);
            db.Adm_Security_Clearances.Remove(adm_Security_Clearance);
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
