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
    public class Ref_Contract_Vehicle_LCATController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Contract_Vehicle_LCAT
        public ActionResult Index()
        {
            var ref_Contract_Vehicle_LCATs = db.Ref_Contract_Vehicle_LCATs.Include(r => r.Adm_Contract_Vehicle).Include(r => r.Adm_Degree);
            return View(ref_Contract_Vehicle_LCATs.ToList());
        }

        // GET: Ref_Contract_Vehicle_LCAT/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Contract_Vehicle_LCAT ref_Contract_Vehicle_LCAT = db.Ref_Contract_Vehicle_LCATs.Find(id);
            if (ref_Contract_Vehicle_LCAT == null)
            {
                return HttpNotFound();
            }
            return View(ref_Contract_Vehicle_LCAT);
        }

        // GET: Ref_Contract_Vehicle_LCAT/Create
        public ActionResult Create()
        {
            ViewBag.Contract_Vehicle_ID = new SelectList(db.Adm_Contract_Vehicles, "ID", "Vehicle_Name");
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree");
            return View();
        }

        // POST: Ref_Contract_Vehicle_LCAT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_Vehicle_ID,LCAT,LCAT_Description,Years_of_Experience_with_Degree,Degree_ID")] Ref_Contract_Vehicle_LCAT ref_Contract_Vehicle_LCAT)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Contract_Vehicle_LCATs.Add(ref_Contract_Vehicle_LCAT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Contract_Vehicle_ID = new SelectList(db.Adm_Contract_Vehicles, "ID", "Vehicle_Name", ref_Contract_Vehicle_LCAT.Contract_Vehicle_ID);
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", ref_Contract_Vehicle_LCAT.Degree_ID);
            return View(ref_Contract_Vehicle_LCAT);
        }

        // GET: Ref_Contract_Vehicle_LCAT/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Contract_Vehicle_LCAT ref_Contract_Vehicle_LCAT = db.Ref_Contract_Vehicle_LCATs.Find(id);
            if (ref_Contract_Vehicle_LCAT == null)
            {
                return HttpNotFound();
            }
            ViewBag.Contract_Vehicle_ID = new SelectList(db.Adm_Contract_Vehicles, "ID", "Vehicle_Name", ref_Contract_Vehicle_LCAT.Contract_Vehicle_ID);
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", ref_Contract_Vehicle_LCAT.Degree_ID);
            return View(ref_Contract_Vehicle_LCAT);
        }

        // POST: Ref_Contract_Vehicle_LCAT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_Vehicle_ID,LCAT,LCAT_Description,Years_of_Experience_with_Degree,Degree_ID")] Ref_Contract_Vehicle_LCAT ref_Contract_Vehicle_LCAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Contract_Vehicle_LCAT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contract_Vehicle_ID = new SelectList(db.Adm_Contract_Vehicles, "ID", "Vehicle_Name", ref_Contract_Vehicle_LCAT.Contract_Vehicle_ID);
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", ref_Contract_Vehicle_LCAT.Degree_ID);
            return View(ref_Contract_Vehicle_LCAT);
        }

        // GET: Ref_Contract_Vehicle_LCAT/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Contract_Vehicle_LCAT ref_Contract_Vehicle_LCAT = db.Ref_Contract_Vehicle_LCATs.Find(id);
            if (ref_Contract_Vehicle_LCAT == null)
            {
                return HttpNotFound();
            }
            return View(ref_Contract_Vehicle_LCAT);
        }

        // POST: Ref_Contract_Vehicle_LCAT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Contract_Vehicle_LCAT ref_Contract_Vehicle_LCAT = db.Ref_Contract_Vehicle_LCATs.Find(id);
            db.Ref_Contract_Vehicle_LCATs.Remove(ref_Contract_Vehicle_LCAT);
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
