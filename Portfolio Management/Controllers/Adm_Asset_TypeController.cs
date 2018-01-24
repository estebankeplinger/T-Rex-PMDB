using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;

namespace Portfolio_Management.Controllers
{
    [Authorize]
    public class Adm_Asset_TypeController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Asset_Type
        public ActionResult Index()
        {
            return View(db.Adm_Asset_Types.ToList());
        }

        // GET: Adm_Asset_Type/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Asset_Type adm_Asset_Type = db.Adm_Asset_Types.Find(id);
            if (adm_Asset_Type == null)
            {
                return HttpNotFound();
            }
            return View(adm_Asset_Type);
        }

        // GET: Adm_Asset_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Asset_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Asset_Type")] Adm_Asset_Type adm_Asset_Type)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Asset_Types.Add(adm_Asset_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Asset_Type);
        }

        // GET: Adm_Asset_Type/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Asset_Type adm_Asset_Type = db.Adm_Asset_Types.Find(id);
            if (adm_Asset_Type == null)
            {
                return HttpNotFound();
            }
            return View(adm_Asset_Type);
        }

        // POST: Adm_Asset_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Asset_Type")] Adm_Asset_Type adm_Asset_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Asset_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Asset_Type);
        }

        // GET: Adm_Asset_Type/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Asset_Type adm_Asset_Type = db.Adm_Asset_Types.Find(id);
            if (adm_Asset_Type == null)
            {
                return HttpNotFound();
            }
            return View(adm_Asset_Type);
        }

        // POST: Adm_Asset_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Asset_Type adm_Asset_Type = db.Adm_Asset_Types.Find(id);
            db.Adm_Asset_Types.Remove(adm_Asset_Type);
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
