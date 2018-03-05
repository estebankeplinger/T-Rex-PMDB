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
    public class Ref_Telework_AgreementController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Telework_Agreement
        public ActionResult Index()
        {
            return View(db.Ref_Telework_Agreements.ToList());
        }

        // GET: Ref_Telework_Agreement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Telework_Agreement ref_Telework_Agreement = db.Ref_Telework_Agreements.Find(id);
            if (ref_Telework_Agreement == null)
            {
                return HttpNotFound();
            }
            return View(ref_Telework_Agreement);
        }

        // GET: Ref_Telework_Agreement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ref_Telework_Agreement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Telework_Agreement")] Ref_Telework_Agreement ref_Telework_Agreement)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Telework_Agreements.Add(ref_Telework_Agreement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ref_Telework_Agreement);
        }

        // GET: Ref_Telework_Agreement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Telework_Agreement ref_Telework_Agreement = db.Ref_Telework_Agreements.Find(id);
            if (ref_Telework_Agreement == null)
            {
                return HttpNotFound();
            }
            return View(ref_Telework_Agreement);
        }

        // POST: Ref_Telework_Agreement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Telework_Agreement")] Ref_Telework_Agreement ref_Telework_Agreement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Telework_Agreement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ref_Telework_Agreement);
        }

        // GET: Ref_Telework_Agreement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Telework_Agreement ref_Telework_Agreement = db.Ref_Telework_Agreements.Find(id);
            if (ref_Telework_Agreement == null)
            {
                return HttpNotFound();
            }
            return View(ref_Telework_Agreement);
        }

        // POST: Ref_Telework_Agreement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Telework_Agreement ref_Telework_Agreement = db.Ref_Telework_Agreements.Find(id);
            db.Ref_Telework_Agreements.Remove(ref_Telework_Agreement);
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
