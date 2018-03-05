using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
/*
 * Currently receiving EF error:
 * Unable to update the EntitySet 'Staff Asset' because it has a DefiningQuery and no <InsertFunction> element exists in the <ModificationFunctionMapping> element to support the current operation.
 */
namespace Portfolio_Management.Controllers
{
    public class Staff_AssetController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Staff_Asset
        public ActionResult Index()
        {
            var staff_Assets = db.Staff_Assets.Include(s => s.Contract).Include(s => s.Ref_Asset).Include(s => s.Staff);
            return View(staff_Assets.ToList());
        }

        // GET: Staff_Asset/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Asset staff_Asset = db.Staff_Assets.Find(id);
            if (staff_Asset == null)
            {
                return HttpNotFound();
            }
            return View(staff_Asset);
        }

        // GET: Staff_Asset/Create
        public ActionResult Create()
        {
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By");
            ViewBag.Asset_ID_ = new SelectList(db.Ref_Assets, "ID", "Asset_Name");
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            return View();
        }

        // POST: Staff_Asset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_ID,Contract_ID,Asset_ID_,Item_Number,Date_Issued,Date_Returrned,Notes,Created_On,Created_By,Modified_On,Modified_By")] Staff_Asset staff_Asset)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Assets.Add(staff_Asset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", staff_Asset.Contract_ID);
            ViewBag.Asset_ID_ = new SelectList(db.Ref_Assets, "ID", "Asset_Name", staff_Asset.Asset_ID_);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Asset.Staff_ID);
            return View(staff_Asset);
        }

        // GET: Staff_Asset/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Asset staff_Asset = db.Staff_Assets.Find(id);
            if (staff_Asset == null)
            {
                return HttpNotFound();
            }
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", staff_Asset.Contract_ID);
            ViewBag.Asset_ID_ = new SelectList(db.Ref_Assets, "ID", "Asset_Name", staff_Asset.Asset_ID_);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Asset.Staff_ID);
            return View(staff_Asset);
        }

        // POST: Staff_Asset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_ID,Contract_ID,Asset_ID_,Item_Number,Date_Issued,Date_Returrned,Notes,Created_On,Created_By,Modified_On,Modified_By")] Staff_Asset staff_Asset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Asset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", staff_Asset.Contract_ID);
            ViewBag.Asset_ID_ = new SelectList(db.Ref_Assets, "ID", "Asset_Name", staff_Asset.Asset_ID_);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Asset.Staff_ID);
            return View(staff_Asset);
        }

        // GET: Staff_Asset/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Asset staff_Asset = db.Staff_Assets.Find(id);
            if (staff_Asset == null)
            {
                return HttpNotFound();
            }
            return View(staff_Asset);
        }

        // POST: Staff_Asset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff_Asset staff_Asset = db.Staff_Assets.Find(id);
            db.Staff_Assets.Remove(staff_Asset);
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
