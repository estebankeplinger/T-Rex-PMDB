using System;
using System.Collections.Generic;
//using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
using System.Diagnostics;
using Portfolio_Management.CustomFilters;

namespace Portfolio_Management.Controllers
{
    [AuthLog(Roles = "User")]
    public class Adm_AgencyController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Agency
        public ActionResult Index()
        {
            return View(db.Adm_Agencies.ToList());
        }

        // GET: Adm_Agency/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Agency adm_Agency = db.Adm_Agencies.Find(id);
            if (adm_Agency == null)
            {
                return HttpNotFound();
            }
            return View(adm_Agency);
        }

        // GET: Adm_Agency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Agency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Agency")] Adm_Agency adm_Agency)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Agencies.Add(adm_Agency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Agency);
        }

        // GET: Adm_Agency/Edit/5
        public ActionResult Edit(short? id)
        {
            Debug.WriteLine("id to edit is: "+id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Agency adm_Agency = db.Adm_Agencies.Find(id);
            Debug.WriteLine("Agency is: "+adm_Agency.Agency);
            if (adm_Agency == null)
            {
                return HttpNotFound();
            }
            Debug.WriteLine("Returning adm_agency");
            return View(adm_Agency);
        }

        // POST: Adm_Agency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Agency")] Adm_Agency adm_Agency)
        {

            if (ModelState.IsValid)
            {
                db.Entry(adm_Agency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Agency);
        }

        // GET: Adm_Agency/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Agency adm_Agency = db.Adm_Agencies.Find(id);
            if (adm_Agency == null)
            {
                return HttpNotFound();
            }
            return View(adm_Agency);
        }

        // POST: Adm_Agency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Agency adm_Agency = db.Adm_Agencies.Find(id);
            db.Adm_Agencies.Remove(adm_Agency);
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
