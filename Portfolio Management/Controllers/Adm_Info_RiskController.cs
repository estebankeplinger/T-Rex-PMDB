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
    public class Adm_Info_RiskController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Adm_Info_Risk
        public ActionResult Index()
        {
            return View(db.Adm_Info_Risks.ToList());
        }

        // GET: Adm_Info_Risk/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Info_Risk adm_Info_Risk = db.Adm_Info_Risks.Find(id);
            if (adm_Info_Risk == null)
            {
                return HttpNotFound();
            }
            return View(adm_Info_Risk);
        }

        // GET: Adm_Info_Risk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adm_Info_Risk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Info_Risk")] Adm_Info_Risk adm_Info_Risk)
        {
            if (ModelState.IsValid)
            {
                db.Adm_Info_Risks.Add(adm_Info_Risk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adm_Info_Risk);
        }

        // GET: Adm_Info_Risk/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Info_Risk adm_Info_Risk = db.Adm_Info_Risks.Find(id);
            if (adm_Info_Risk == null)
            {
                return HttpNotFound();
            }
            return View(adm_Info_Risk);
        }

        // POST: Adm_Info_Risk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Info_Risk")] Adm_Info_Risk adm_Info_Risk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adm_Info_Risk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adm_Info_Risk);
        }

        // GET: Adm_Info_Risk/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adm_Info_Risk adm_Info_Risk = db.Adm_Info_Risks.Find(id);
            if (adm_Info_Risk == null)
            {
                return HttpNotFound();
            }
            return View(adm_Info_Risk);
        }

        // POST: Adm_Info_Risk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Adm_Info_Risk adm_Info_Risk = db.Adm_Info_Risks.Find(id);
            db.Adm_Info_Risks.Remove(adm_Info_Risk);
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
