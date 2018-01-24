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
    public class Adm_DegreeController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Degree
        public ActionResult Index()
        {
            return View(db.Adm_Degrees.ToList());
        }

        // GET: Adm_Degree/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Degree adm_Degree = db.Adm_Degrees.Find(id);
            if (adm_Degree == null)
            {
                return HttpNotFound();
            }
            return View(adm_Degree);
        }

        // GET: Adm_Degree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Degree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Degree,Offset")] Adm_Degree adm_Degree)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Degrees.Add(adm_Degree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Degree);
        }

        // GET: Adm_Degree/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Degree adm_Degree = db.Adm_Degrees.Find(id);
            if (adm_Degree == null)
            {
                return HttpNotFound();
            }
            return View(adm_Degree);
        }

        // POST: Adm_Degree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Degree,Offset")] Adm_Degree adm_Degree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Degree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Degree);
        }

        // GET: Adm_Degree/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Degree adm_Degree = db.Adm_Degrees.Find(id);
            if (adm_Degree == null)
            {
                return HttpNotFound();
            }
            return View(adm_Degree);
        }

        // POST: Adm_Degree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Degree adm_Degree = db.Adm_Degrees.Find(id);
            db.Adm_Degrees.Remove(adm_Degree);
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
