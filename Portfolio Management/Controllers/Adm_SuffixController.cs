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
    public class Adm_SuffixController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Suffix
        public ActionResult Index()
        {
            return View(db.Adm_Suffixes.ToList());
        }

        //// GET: Adm_Suffix/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Adm_Suffix adm_Suffix = db.Adm_Suffixes.Find(id);
        //    if (adm_Suffix == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(adm_Suffix);
        //}

        // GET: Adm_Suffix/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Suffix/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Suffix")] Adm_Suffix adm_Suffix)
        {
            if (adm_Suffix.Suffix.Contains("."))
            {
                ModelState.AddModelError("Suffix", "Suffix cannot contain the '.' character");
            }
            if (ModelState.IsValid)
            {
                db.Adm_Suffixes.Add(adm_Suffix);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Suffix);
        }

        //// GET: Adm_Suffix/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Adm_Suffix adm_Suffix = db.Adm_Suffixes.Find(id);
        //    if (adm_Suffix == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(adm_Suffix);
        //}

        //// POST: Adm_Suffix/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Suffix")] Adm_Suffix adm_Suffix)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(adm_Suffix).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(adm_Suffix);
        //}

        // GET: Adm_Suffix/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Suffix adm_Suffix = db.Adm_Suffixes.Find(id);
            if (adm_Suffix == null)
            {
                return HttpNotFound();
            }
            return View(adm_Suffix);
        }

        // POST: Adm_Suffix/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Adm_Suffix adm_Suffix = db.Adm_Suffixes.Find(id);
            db.Adm_Suffixes.Remove(adm_Suffix);
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
