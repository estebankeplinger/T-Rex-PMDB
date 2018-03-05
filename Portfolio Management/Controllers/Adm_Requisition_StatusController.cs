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
    public class Adm_Requisition_StatusController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Requisition_Status
        public ActionResult Index()
        {
            return View(db.Adm_Requisition_Status.ToList());
        }

        // GET: Adm_Requisition_Status/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Requisition_Status adm_Requisition_Status = db.Adm_Requisition_Status.Find(id);
            if (adm_Requisition_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Requisition_Status);
        }

        // GET: Adm_Requisition_Status/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Requisition_Status/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Status")] Adm_Requisition_Status adm_Requisition_Status)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Requisition_Status.Add(adm_Requisition_Status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Requisition_Status);
        }

        // GET: Adm_Requisition_Status/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Requisition_Status adm_Requisition_Status = db.Adm_Requisition_Status.Find(id);
            if (adm_Requisition_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Requisition_Status);
        }

        // POST: Adm_Requisition_Status/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Status")] Adm_Requisition_Status adm_Requisition_Status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Requisition_Status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Requisition_Status);
        }

        // GET: Adm_Requisition_Status/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Requisition_Status adm_Requisition_Status = db.Adm_Requisition_Status.Find(id);
            if (adm_Requisition_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Requisition_Status);
        }

        // POST: Adm_Requisition_Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Requisition_Status adm_Requisition_Status = db.Adm_Requisition_Status.Find(id);
            db.Adm_Requisition_Status.Remove(adm_Requisition_Status);
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
