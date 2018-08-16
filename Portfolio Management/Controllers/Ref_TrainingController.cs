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
    public class Ref_TrainingController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Training
        public ActionResult Index()
        {
            var ref_Trainings = db.Ref_Trainings.Include(r => r.Contract);
            return View(ref_Trainings.ToList());
        }

        // GET: Ref_Training/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Training ref_Training = db.Ref_Trainings.Find(id);
            if (ref_Training == null)
            {
                return HttpNotFound();
            }
            return View(ref_Training);
        }

        // GET: Ref_Training/Create
        public ActionResult Create()
        {
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By");
            return View();
        }

        // POST: Ref_Training/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_ID,Training,Date_Due,Instructions")] Ref_Training ref_Training)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Trainings.Add(ref_Training);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", ref_Training.Contract_ID);
            return View(ref_Training);
        }

        // GET: Ref_Training/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Training ref_Training = db.Ref_Trainings.Find(id);
            if (ref_Training == null)
            {
                return HttpNotFound();
            }
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", ref_Training.Contract_ID);
            return View(ref_Training);
        }

        // POST: Ref_Training/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_ID,Training,Date_Due,Instructions")] Ref_Training ref_Training)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Training).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", ref_Training.Contract_ID);
            return View(ref_Training);
        }

        // GET: Ref_Training/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Training ref_Training = db.Ref_Trainings.Find(id);
            if (ref_Training == null)
            {
                return HttpNotFound();
            }
            return View(ref_Training);
        }

        // POST: Ref_Training/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Training ref_Training = db.Ref_Trainings.Find(id);
            db.Ref_Trainings.Remove(ref_Training);
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
