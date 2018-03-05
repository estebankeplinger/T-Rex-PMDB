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
    public class CertificationsController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Certifications
        public ActionResult Index()
        {
            var certifications = db.Certifications.Include(c => c.Staff);
            return View(certifications.ToList());
        }

        // GET: Certifications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certification certification = db.Certifications.Find(id);
            if (certification == null)
            {
                return HttpNotFound();
            }
            return View(certification);
        }

        // GET: Certifications/Create
        public ActionResult Create()
        {
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            return View();
        }

        // POST: Certifications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_ID,Certification1,Issuing_Agency,Certification_ID,Date_Issued,Expiration_Date,Created_On,Created_By,Modified_On,Modified_By")] Certification certification)
        {
            if (ModelState.IsValid)
            {
                db.Certifications.Add(certification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", certification.Staff_ID);
            return View(certification);
        }

        // GET: Certifications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certification certification = db.Certifications.Find(id);
            if (certification == null)
            {
                return HttpNotFound();
            }
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", certification.Staff_ID);
            return View(certification);
        }

        // POST: Certifications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_ID,Certification1,Issuing_Agency,Certification_ID,Date_Issued,Expiration_Date,Created_On,Created_By,Modified_On,Modified_By")] Certification certification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", certification.Staff_ID);
            return View(certification);
        }

        // GET: Certifications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certification certification = db.Certifications.Find(id);
            if (certification == null)
            {
                return HttpNotFound();
            }
            return View(certification);
        }

        // POST: Certifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Certification certification = db.Certifications.Find(id);
            db.Certifications.Remove(certification);
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
