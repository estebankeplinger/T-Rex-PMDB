using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;

/*
 * Error:
 * A dependent property in a ReferentialConstraint is mapped to a store-generated column. Column: 'ID'
 * 
 */
namespace Portfolio_Management.Controllers
{
    public class Staff_ClearanceController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Staff_Clearance
        public ActionResult Index()
        {
            var staff_Clearances = db.Staff_Clearances.Include(s => s.Adm_Security_Clearance).Include(s => s.Contract).Include(s => s.Staff);
            return View(staff_Clearances.ToList());
        }

        // GET: Staff_Clearance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Clearance staff_Clearance = db.Staff_Clearances.Find(id);
            if (staff_Clearance == null)
            {
                return HttpNotFound();
            }
            return View(staff_Clearance);
        }

        // GET: Staff_Clearance/Create
        public ActionResult Create()
        {
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            ViewBag.Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance");
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title");
            ViewBag.ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            return View();
        }

        // POST: Staff_Clearance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_ID,Security_Clearance_ID,Date_Authorized,Contract_ID,Created_On,Created_By,Modified_On,Modified_By")] Staff_Clearance staff_Clearance)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Clearances.Add(staff_Clearance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Clearance.Staff_ID);
            ViewBag.Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance", staff_Clearance.Security_Clearance_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", staff_Clearance.Contract_ID);
            ViewBag.ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Clearance.ID);
            return View(staff_Clearance);
        }

        // GET: Staff_Clearance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Clearance staff_Clearance = db.Staff_Clearances.Find(id);
            if (staff_Clearance == null)
            {
                return HttpNotFound();
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Clearance.Staff_ID);
            ViewBag.Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance", staff_Clearance.Security_Clearance_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", staff_Clearance.Contract_ID);
            ViewBag.ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Clearance.ID);
            return View(staff_Clearance);
        }

        // POST: Staff_Clearance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_ID,Security_Clearance_ID,Date_Authorized,Contract_ID,Created_On,Created_By,Modified_On,Modified_By")] Staff_Clearance staff_Clearance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Clearance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Clearance.Staff_ID);
            ViewBag.Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance", staff_Clearance.Security_Clearance_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", staff_Clearance.Contract_ID);
            ViewBag.ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Clearance.ID);
            return View(staff_Clearance);
        }

        // GET: Staff_Clearance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Clearance staff_Clearance = db.Staff_Clearances.Find(id);
            if (staff_Clearance == null)
            {
                return HttpNotFound();
            }
            return View(staff_Clearance);
        }

        // POST: Staff_Clearance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff_Clearance staff_Clearance = db.Staff_Clearances.Find(id);
            db.Staff_Clearances.Remove(staff_Clearance);
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
