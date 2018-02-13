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
    public class Adm_Exit_ReasonController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Exit_Reason
        public ActionResult Index()
        {
            return View(db.Adm_Exit_Reasons.ToList());
        }

        // GET: Adm_Exit_Reason/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Exit_Reason adm_Exit_Reason = db.Adm_Exit_Reasons.Find(id);
            if (adm_Exit_Reason == null)
            {
                return HttpNotFound();
            }
            return View(adm_Exit_Reason);
        }

        // GET: Adm_Exit_Reason/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Exit_Reason/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Exit_Reason")] Adm_Exit_Reason adm_Exit_Reason)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Exit_Reasons.Add(adm_Exit_Reason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Exit_Reason);
        }

        // GET: Adm_Exit_Reason/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Exit_Reason adm_Exit_Reason = db.Adm_Exit_Reasons.Find(id);
            if (adm_Exit_Reason == null)
            {
                return HttpNotFound();
            }
            return View(adm_Exit_Reason);
        }

        // POST: Adm_Exit_Reason/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Exit_Reason")] Adm_Exit_Reason adm_Exit_Reason)
        {
            System.Diagnostics.Debug.WriteLine("Sent exit reason is: "+adm_Exit_Reason.Exit_Reason);

            if (ModelState.IsValid)
            {
               
                db.Entry(adm_Exit_Reason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Exit_Reason);
        }

        // GET: Adm_Exit_Reason/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Exit_Reason adm_Exit_Reason = db.Adm_Exit_Reasons.Find(id);
            if (adm_Exit_Reason == null)
            {
                return HttpNotFound();
            }
            return View(adm_Exit_Reason);
        }

        // POST: Adm_Exit_Reason/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Exit_Reason adm_Exit_Reason = db.Adm_Exit_Reasons.Find(id);
            db.Adm_Exit_Reasons.Remove(adm_Exit_Reason);
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
