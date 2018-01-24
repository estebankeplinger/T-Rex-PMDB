using System;
using System.Collections.Generic;
//using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;

namespace Portfolio_Management.Controllers
{
    [Authorize]
    public class Adm_Contract_VehicleController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Contract_Vehicle
        public ActionResult Index()
        {
            return View(db.Adm_Contract_Vehicles.ToList());
        }

        // GET: Adm_Contract_Vehicle/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Contract_Vehicle adm_Contract_Vehicle = db.Adm_Contract_Vehicles.Find(id);
            if (adm_Contract_Vehicle == null)
            {
                return HttpNotFound();
            }
            return View(adm_Contract_Vehicle);
        }

        // GET: Adm_Contract_Vehicle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Contract_Vehicle/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Vehicle_Name")] Adm_Contract_Vehicle adm_Contract_Vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Contract_Vehicles.Add(adm_Contract_Vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Contract_Vehicle);
        }

        // GET: Adm_Contract_Vehicle/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Contract_Vehicle adm_Contract_Vehicle = db.Adm_Contract_Vehicles.Find(id);
            if (adm_Contract_Vehicle == null)
            {
                return HttpNotFound();
            }
            return View(adm_Contract_Vehicle);
        }

        // POST: Adm_Contract_Vehicle/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Vehicle_Name")] Adm_Contract_Vehicle adm_Contract_Vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Contract_Vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Contract_Vehicle);
        }

        // GET: Adm_Contract_Vehicle/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Contract_Vehicle adm_Contract_Vehicle = db.Adm_Contract_Vehicles.Find(id);
            if (adm_Contract_Vehicle == null)
            {
                return HttpNotFound();
            }
            return View(adm_Contract_Vehicle);
        }

        // POST: Adm_Contract_Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Contract_Vehicle adm_Contract_Vehicle = db.Adm_Contract_Vehicles.Find(id);
            db.Adm_Contract_Vehicles.Remove(adm_Contract_Vehicle);
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
