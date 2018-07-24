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
    public class EducationsController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Educations
        public ActionResult Index()
        {
            var educations = db.Educations.Include(e => e.Adm_Degree).Include(e => e.Staff);
            return View(educations.ToList());
        }

        // GET: Educations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = db.Educations.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // GET: Educations/Create
        public ActionResult Create()
        {
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree");
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            ViewBag.DateTime = DateTime.Now;
            return View();
        }

        // POST: Educations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_ID,School,Degree_ID,Completed_Date,Created_On,Created_By,Modified_On,Modified_By")] Education education)
        {
            if (ModelState.IsValid)
            {
                db.Educations.Add(education);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", education.Degree_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", education.Staff_ID);
            return View(education);
        }

        // GET: Educations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = db.Educations.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", education.Degree_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", education.Staff_ID);
            return View(education);
        }

        // POST: Educations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_ID,School,Degree_ID,Completed_Date,Created_On,Created_By,Modified_On,Modified_By")] Education education)
        {
            if (ModelState.IsValid)
            {
                db.Entry(education).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", education.Degree_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", education.Staff_ID);
            return View(education);
        }

        // GET: Educations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = db.Educations.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // POST: Educations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Education education = db.Educations.Find(id);
            db.Educations.Remove(education);
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
