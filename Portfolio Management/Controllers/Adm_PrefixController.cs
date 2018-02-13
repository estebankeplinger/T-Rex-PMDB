using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
using System.Diagnostics;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace Portfolio_Management.Controllers
{
    public class Adm_PrefixController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Prefix
        public ActionResult Index()
        {
            Debug.WriteLine("In index method of prefix controller");
            return View(db.Adm_Prefixes.ToList());
        }

        // GET: Adm_Prefix/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Prefix adm_Prefix = db.Adm_Prefixes.Find(id);
            if (adm_Prefix == null)
            {
                return HttpNotFound();
            }
            return View(adm_Prefix);
        }

        // GET: Adm_Prefix/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Prefix/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Prefix")] Adm_Prefix adm_Prefix)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Prefixes.Add(adm_Prefix);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Prefix);
        }

        // GET: Adm_Prefix/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Prefix adm_Prefix = db.Adm_Prefixes.Find(id);
            if (adm_Prefix == null)
            {
                return HttpNotFound();
            }
            return View(adm_Prefix);
        }

        // POST: Adm_Prefix/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Prefix")] Adm_Prefix adm_Prefix)
        {
            Debug.WriteLine("____________________________IN POST EDIT METHOD");
            Debug.WriteLine(adm_Prefix.Prefix);

            if (ModelState.IsValid)
            {
                db.Entry(adm_Prefix).State = EntityState.Modified;      
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(adm_Prefix);
        }

        // GET: Adm_Prefix/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Prefix adm_Prefix = db.Adm_Prefixes.Find(id);
            if (adm_Prefix == null)
            {
                return HttpNotFound();
            }
            return View(adm_Prefix);
        }

        // POST: Adm_Prefix/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Adm_Prefix adm_Prefix = db.Adm_Prefixes.Find(id);
            db.Adm_Prefixes.Remove(adm_Prefix);
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
