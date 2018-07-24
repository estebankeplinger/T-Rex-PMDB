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

namespace Portfolio_Management.Controllers
{
    [Authorize]
    public class Adm_Clearance_StatusController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Clearance_Status
        public ActionResult Index()
        {
            return View(db.Adm_Clearance_Status.ToList());
        }

        // GET: Adm_Clearance_Status/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Clearance_Status adm_Clearance_Status = db.Adm_Clearance_Status.Find(id);
            if (adm_Clearance_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Clearance_Status);
        }

        // GET: Adm_Clearance_Status/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Clearance_Status/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Clearance_Status")] Adm_Clearance_Status adm_Clearance_Status)
        {
            if (ModelState.IsValid)
            {
                
                try
                {
                    Debug.WriteLine("This is the id: " + adm_Clearance_Status.ID);
                    db.Adm_Clearance_Status.Add(adm_Clearance_Status);
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
                return RedirectToAction("Index");
            }

            return View(adm_Clearance_Status);
        }

        // GET: Adm_Clearance_Status/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Clearance_Status adm_Clearance_Status = db.Adm_Clearance_Status.Find(id);
            if (adm_Clearance_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Clearance_Status);
        }

        // POST: Adm_Clearance_Status/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Clearance_Status")] Adm_Clearance_Status adm_Clearance_Status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Clearance_Status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Clearance_Status);
        }

        // GET: Adm_Clearance_Status/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Clearance_Status adm_Clearance_Status = db.Adm_Clearance_Status.Find(id);
            if (adm_Clearance_Status == null)
            {
                return HttpNotFound();
            }
            return View(adm_Clearance_Status);
        }

        // POST: Adm_Clearance_Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Clearance_Status adm_Clearance_Status = db.Adm_Clearance_Status.Find(id);
            db.Adm_Clearance_Status.Remove(adm_Clearance_Status);
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
