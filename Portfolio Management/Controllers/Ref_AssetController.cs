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
    public class Ref_AssetController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Asset
        public ActionResult Index()
        {
            var ref_Assets = db.Ref_Assets.Include(r => r.Adm_Asset_Type);
            return View(ref_Assets.ToList());
        }

        // GET: Ref_Asset/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Asset ref_Asset = db.Ref_Assets.Find(id);
            if (ref_Asset == null)
            {
                return HttpNotFound();
            }
            return View(ref_Asset);
        }

        // GET: Ref_Asset/Create
        public ActionResult Create()
        {
            ViewBag.Asset_Type_ID = new SelectList(db.Adm_Asset_Types, "ID", "Asset_Type");
            return View();
        }

        // POST: Ref_Asset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Asset_Name,Asset_Type_ID")] Ref_Asset ref_Asset)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Assets.Add(ref_Asset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Asset_Type_ID = new SelectList(db.Adm_Asset_Types, "ID", "Asset_Type", ref_Asset.Asset_Type_ID);
            return View(ref_Asset);
        }

        // GET: Ref_Asset/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Asset ref_Asset = db.Ref_Assets.Find(id);
            if (ref_Asset == null)
            {
                return HttpNotFound();
            }
            ViewBag.Asset_Type_ID = new SelectList(db.Adm_Asset_Types, "ID", "Asset_Type", ref_Asset.Asset_Type_ID);
            return View(ref_Asset);
        }

        // POST: Ref_Asset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Asset_Name,Asset_Type_ID")] Ref_Asset ref_Asset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Asset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Asset_Type_ID = new SelectList(db.Adm_Asset_Types, "ID", "Asset_Type", ref_Asset.Asset_Type_ID);
            return View(ref_Asset);
        }

        // GET: Ref_Asset/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Asset ref_Asset = db.Ref_Assets.Find(id);
            if (ref_Asset == null)
            {
                return HttpNotFound();
            }
            return View(ref_Asset);
        }

        // POST: Ref_Asset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Asset ref_Asset = db.Ref_Assets.Find(id);
            db.Ref_Assets.Remove(ref_Asset);
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
