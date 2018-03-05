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
    public class Adm_Resume_StatusController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Resume_Status
        public ActionResult Index()
        {
            return View(db.Adm_Resume_Status.ToList());
        }

        // GET: Adm_Resume_Status/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Resume_Status adm_Resume_Status = db.Adm_Resume_Status.Find(id);
            if (adm_Resume_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Resume_Status);
        }

        // GET: Adm_Resume_Status/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Resume_Status/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Status")] Adm_Resume_Status adm_Resume_Status)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Resume_Status.Add(adm_Resume_Status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Resume_Status);
        }

        // GET: Adm_Resume_Status/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Resume_Status adm_Resume_Status = db.Adm_Resume_Status.Find(id);
            if (adm_Resume_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Resume_Status);
        }

        // POST: Adm_Resume_Status/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Status")] Adm_Resume_Status adm_Resume_Status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Resume_Status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Resume_Status);
        }

        // GET: Adm_Resume_Status/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Resume_Status adm_Resume_Status = db.Adm_Resume_Status.Find(id);
            if (adm_Resume_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Resume_Status);
        }

        // POST: Adm_Resume_Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Resume_Status adm_Resume_Status = db.Adm_Resume_Status.Find(id);
            db.Adm_Resume_Status.Remove(adm_Resume_Status);
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
