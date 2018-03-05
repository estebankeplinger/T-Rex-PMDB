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
    public class Staff_PositionController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Staff_Position
        public ActionResult Index()
        {
            var staff_Positions = db.Staff_Positions.Include(s => s.Adm_Resume_Status).Include(s => s.Contract_Position).Include(s => s.Ref_Telework_Agreement).Include(s => s.Staff);
            return View(staff_Positions.ToList());
        }

        // GET: Staff_Position/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Position staff_Position = db.Staff_Positions.Find(id);
            if (staff_Position == null)
            {
                return HttpNotFound();
            }
            return View(staff_Position);
        }

        // GET: Staff_Position/Create
        public ActionResult Create()
        {
            ViewBag.Resume_Status_ID = new SelectList(db.Adm_Resume_Status, "ID", "Status");
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID");
            ViewBag.Telework_Agreement_ID = new SelectList(db.Ref_Telework_Agreements, "ID", "Telework_Agreement");
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            return View();
        }

        // POST: Staff_Position/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Staff_ID,Contract_Position_ID,IsActive,Planned_Start_Date,Active_Start_Date,Active_End_Date,Telework_Agreement_ID,Resume_Status_ID,Is_Resume_Compliant,Is_LCAT_Compliant,Compliance_Notes,Email_Address,Desk_Phone,Cell_Phone,Created_On,Created_By,Modified_On,Modified_By")] Staff_Position staff_Position)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Positions.Add(staff_Position);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Resume_Status_ID = new SelectList(db.Adm_Resume_Status, "ID", "Status", staff_Position.Resume_Status_ID);
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", staff_Position.Contract_Position_ID);
            ViewBag.Telework_Agreement_ID = new SelectList(db.Ref_Telework_Agreements, "ID", "Telework_Agreement", staff_Position.Telework_Agreement_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Position.Staff_ID);
            return View(staff_Position);
        }

        // GET: Staff_Position/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Position staff_Position = db.Staff_Positions.Find(id);
            if (staff_Position == null)
            {
                return HttpNotFound();
            }
            ViewBag.Resume_Status_ID = new SelectList(db.Adm_Resume_Status, "ID", "Status", staff_Position.Resume_Status_ID);
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", staff_Position.Contract_Position_ID);
            ViewBag.Telework_Agreement_ID = new SelectList(db.Ref_Telework_Agreements, "ID", "Telework_Agreement", staff_Position.Telework_Agreement_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Position.Staff_ID);
            return View(staff_Position);
        }

        // POST: Staff_Position/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Staff_ID,Contract_Position_ID,IsActive,Planned_Start_Date,Active_Start_Date,Active_End_Date,Telework_Agreement_ID,Resume_Status_ID,Is_Resume_Compliant,Is_LCAT_Compliant,Compliance_Notes,Email_Address,Desk_Phone,Cell_Phone,Created_On,Created_By,Modified_On,Modified_By")] Staff_Position staff_Position)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Position).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Resume_Status_ID = new SelectList(db.Adm_Resume_Status, "ID", "Status", staff_Position.Resume_Status_ID);
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", staff_Position.Contract_Position_ID);
            ViewBag.Telework_Agreement_ID = new SelectList(db.Ref_Telework_Agreements, "ID", "Telework_Agreement", staff_Position.Telework_Agreement_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Position.Staff_ID);
            return View(staff_Position);
        }

        // GET: Staff_Position/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Position staff_Position = db.Staff_Positions.Find(id);
            if (staff_Position == null)
            {
                return HttpNotFound();
            }
            return View(staff_Position);
        }

        // POST: Staff_Position/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff_Position staff_Position = db.Staff_Positions.Find(id);
            db.Staff_Positions.Remove(staff_Position);
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
