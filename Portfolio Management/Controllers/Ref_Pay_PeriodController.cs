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
    public class Ref_Pay_PeriodController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Pay_Period
        public ActionResult Index()
        {
            return View(db.Ref_Pay_Periods.ToList());
        }

        // GET: Ref_Pay_Period/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Pay_Period ref_Pay_Period = db.Ref_Pay_Periods.Find(id);
            if (ref_Pay_Period == null)
            {
                return HttpNotFound();
            }
            return View(ref_Pay_Period);
        }

        // GET: Ref_Pay_Period/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ref_Pay_Period/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Period__,Year,Month,Start,End")] Ref_Pay_Period ref_Pay_Period)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Pay_Periods.Add(ref_Pay_Period);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ref_Pay_Period);
        }

        // GET: Ref_Pay_Period/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Pay_Period ref_Pay_Period = db.Ref_Pay_Periods.Find(id);
            if (ref_Pay_Period == null)
            {
                return HttpNotFound();
            }
            return View(ref_Pay_Period);
        }

        // POST: Ref_Pay_Period/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Period__,Year,Month,Start,End")] Ref_Pay_Period ref_Pay_Period)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Pay_Period).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ref_Pay_Period);
        }

        // GET: Ref_Pay_Period/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Pay_Period ref_Pay_Period = db.Ref_Pay_Periods.Find(id);
            if (ref_Pay_Period == null)
            {
                return HttpNotFound();
            }
            return View(ref_Pay_Period);
        }

        // POST: Ref_Pay_Period/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Pay_Period ref_Pay_Period = db.Ref_Pay_Periods.Find(id);
            db.Ref_Pay_Periods.Remove(ref_Pay_Period);
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
