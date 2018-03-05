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
    public class WorksharesController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Workshares
        public ActionResult Index()
        {
            var workshares = db.Workshares.Include(w => w.Contract_Position).Include(w => w.Ref_Company);
            return View(workshares.ToList());
        }

        // GET: Workshares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workshare workshare = db.Workshares.Find(id);
            if (workshare == null)
            {
                return HttpNotFound();
            }
            return View(workshare);
        }

        // GET: Workshares/Create
        public ActionResult Create()
        {
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID");
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company");
            return View();
        }

        // POST: Workshares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_Position_ID,Company_ID,Date_Released,IsPrimary,Created_On,Created_By,Modified_On,Modified_By")] Workshare workshare)
        {
            if (ModelState.IsValid)
            {
                db.Workshares.Add(workshare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", workshare.Contract_Position_ID);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", workshare.Company_ID);
            return View(workshare);
        }

        // GET: Workshares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workshare workshare = db.Workshares.Find(id);
            if (workshare == null)
            {
                return HttpNotFound();
            }
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", workshare.Contract_Position_ID);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", workshare.Company_ID);
            return View(workshare);
        }

        // POST: Workshares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_Position_ID,Company_ID,Date_Released,IsPrimary,Created_On,Created_By,Modified_On,Modified_By")] Workshare workshare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workshare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", workshare.Contract_Position_ID);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", workshare.Company_ID);
            return View(workshare);
        }

        // GET: Workshares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workshare workshare = db.Workshares.Find(id);
            if (workshare == null)
            {
                return HttpNotFound();
            }
            return View(workshare);
        }

        // POST: Workshares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Workshare workshare = db.Workshares.Find(id);
            db.Workshares.Remove(workshare);
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
