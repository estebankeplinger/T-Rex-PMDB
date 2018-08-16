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
    public class Ref_Contract_LCATController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Contract_LCAT
        public ActionResult Index()
        {
            var ref_Contract_LCATs = db.Ref_Contract_LCATs.Include(r => r.Contract).Include(r => r.Ref_Contract_Vehicle_LCAT);
            return View(ref_Contract_LCATs.ToList());
        }

        // GET: Ref_Contract_LCAT/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Contract_LCAT ref_Contract_LCAT = db.Ref_Contract_LCATs.Find(id);
            if (ref_Contract_LCAT == null)
            {
                return HttpNotFound();
            }
            return View(ref_Contract_LCAT);
        }

        // GET: Ref_Contract_LCAT/Create
        public ActionResult Create()
        {
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title");
            ViewBag.Vehicle_LCAT_ID = new SelectList(db.Ref_Contract_Vehicle_LCATs, "ID", "LCAT");
            return View();
        }

        // POST: Ref_Contract_LCAT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_ID,Vehicle_LCAT_ID,ESF_LCAT,Description,Years_of_Experience_with_Degree")] Ref_Contract_LCAT ref_Contract_LCAT)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Contract_LCATs.Add(ref_Contract_LCAT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", ref_Contract_LCAT.Contract_ID);
            ViewBag.Vehicle_LCAT_ID = new SelectList(db.Ref_Contract_Vehicle_LCATs, "ID", "LCAT", ref_Contract_LCAT.Vehicle_LCAT_ID);
            return View(ref_Contract_LCAT);
        }

        // GET: Ref_Contract_LCAT/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Contract_LCAT ref_Contract_LCAT = db.Ref_Contract_LCATs.Find(id);
            if (ref_Contract_LCAT == null)
            {
                return HttpNotFound();
            }
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", ref_Contract_LCAT.Contract_ID);
            ViewBag.Vehicle_LCAT_ID = new SelectList(db.Ref_Contract_Vehicle_LCATs, "ID", "LCAT", ref_Contract_LCAT.Vehicle_LCAT_ID);
            return View(ref_Contract_LCAT);
        }

        // POST: Ref_Contract_LCAT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_ID,Vehicle_LCAT_ID,ESF_LCAT,Description,Years_of_Experience_with_Degree")] Ref_Contract_LCAT ref_Contract_LCAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Contract_LCAT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", ref_Contract_LCAT.Contract_ID);
            ViewBag.Vehicle_LCAT_ID = new SelectList(db.Ref_Contract_Vehicle_LCATs, "ID", "LCAT", ref_Contract_LCAT.Vehicle_LCAT_ID);
            return View(ref_Contract_LCAT);
        }

        // GET: Ref_Contract_LCAT/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Contract_LCAT ref_Contract_LCAT = db.Ref_Contract_LCATs.Find(id);
            if (ref_Contract_LCAT == null)
            {
                return HttpNotFound();
            }
            return View(ref_Contract_LCAT);
        }

        // POST: Ref_Contract_LCAT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Contract_LCAT ref_Contract_LCAT = db.Ref_Contract_LCATs.Find(id);
            db.Ref_Contract_LCATs.Remove(ref_Contract_LCAT);
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
