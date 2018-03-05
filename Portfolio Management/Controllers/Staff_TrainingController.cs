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
    public class Staff_TrainingController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Staff_Training
        public ActionResult Index()
        {
            var staff_Trainings = db.Staff_Trainings.Include(s => s.Ref_Training).Include(s => s.Staff);
            return View(staff_Trainings.ToList());
        }

        // GET: Staff_Training/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Training staff_Training = db.Staff_Trainings.Find(id);
            if (staff_Training == null)
            {
                return HttpNotFound();
            }
            return View(staff_Training);
        }

        // GET: Staff_Training/Create
        public ActionResult Create()
        {
            ViewBag.Training_ID = new SelectList(db.Ref_Trainings, "ID", "Training");
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            return View();
        }

        // POST: Staff_Training/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_ID,Training_ID,Date_Completed,Created_On,Created_By,Modified_On,Modified_By")] Staff_Training staff_Training)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Trainings.Add(staff_Training);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Training_ID = new SelectList(db.Ref_Trainings, "ID", "Training", staff_Training.Training_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Training.Staff_ID);
            return View(staff_Training);
        }

        // GET: Staff_Training/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Training staff_Training = db.Staff_Trainings.Find(id);
            if (staff_Training == null)
            {
                return HttpNotFound();
            }
            ViewBag.Training_ID = new SelectList(db.Ref_Trainings, "ID", "Training", staff_Training.Training_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Training.Staff_ID);
            return View(staff_Training);
        }

        // POST: Staff_Training/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_ID,Training_ID,Date_Completed,Created_On,Created_By,Modified_On,Modified_By")] Staff_Training staff_Training)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Training).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Training_ID = new SelectList(db.Ref_Trainings, "ID", "Training", staff_Training.Training_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Training.Staff_ID);
            return View(staff_Training);
        }

        // GET: Staff_Training/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Training staff_Training = db.Staff_Trainings.Find(id);
            if (staff_Training == null)
            {
                return HttpNotFound();
            }
            return View(staff_Training);
        }

        // POST: Staff_Training/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff_Training staff_Training = db.Staff_Trainings.Find(id);
            db.Staff_Trainings.Remove(staff_Training);
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
