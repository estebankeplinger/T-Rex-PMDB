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
    public class Adm_ProficiencyController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Proficiency
        public ActionResult Index()
        {
            return View(db.Adm_Proficiencies.ToList());
        }

        // GET: Adm_Proficiency/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Proficiency adm_Proficiency = db.Adm_Proficiencies.Find(id);
            if (adm_Proficiency == null)
            {
                return HttpNotFound();
            }
            return View(adm_Proficiency);
        }

        // GET: Adm_Proficiency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Proficiency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Proficiency_ID,Proficiency")] Adm_Proficiency adm_Proficiency)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Proficiencies.Add(adm_Proficiency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Proficiency);
        }

        // GET: Adm_Proficiency/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Proficiency adm_Proficiency = db.Adm_Proficiencies.Find(id);
            if (adm_Proficiency == null)
            {
                return HttpNotFound();
            }
            return View(adm_Proficiency);
        }

        // POST: Adm_Proficiency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Proficiency_ID,Proficiency")] Adm_Proficiency adm_Proficiency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Proficiency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Proficiency);
        }

        // GET: Adm_Proficiency/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Proficiency adm_Proficiency = db.Adm_Proficiencies.Find(id);
            if (adm_Proficiency == null)
            {
                return HttpNotFound();
            }
            return View(adm_Proficiency);
        }

        // POST: Adm_Proficiency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Proficiency adm_Proficiency = db.Adm_Proficiencies.Find(id);
            db.Adm_Proficiencies.Remove(adm_Proficiency);
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
