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
    public class Contract_PositionController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Contract_Position
        public ActionResult Index()
        {
            var contract_Positions = db.Contract_Positions.Include(c => c.Adm_Info_Risk).Include(c => c.Adm_Requisition_Status).Include(c => c.Adm_Security_Clearance).Include(c => c.Contract).Include(c => c.Contract_WBS).Include(c => c.Ref_Contract_LCAT).Include(c => c.Ref_Role);
            return View(contract_Positions.ToList());
        }

        // GET: Contract_Position/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract_Position contract_Position = db.Contract_Positions.Find(id);
            if (contract_Position == null)
            {
                return HttpNotFound();
            }
            return View(contract_Position);
        }

        // GET: Contract_Position/Create
        public ActionResult Create()
        {
            ViewBag.Info_Risk_ID = new SelectList(db.Adm_Info_Risks, "ID", "Info_Risk");
            ViewBag.Requisition_Status_ID = new SelectList(db.Adm_Requisition_Status, "ID", "Status");
            ViewBag.Required_Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance");
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By");
            ViewBag.Contract_ID = new SelectList(db.Contract_WBS, "ID", "Area");
            ViewBag.LCAT_ID = new SelectList(db.Ref_Contract_LCATs, "ID", "ESF_LCAT");
            ViewBag.Role_ID = new SelectList(db.Ref_Roles, "ID", "Role");
            return View();
        }

        // POST: Contract_Position/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_ID,Role_ID,Contract_WBS_ID,Position__,Info_Risk_ID,LCAT_ID,DateNeeded,Requisition_Status_ID,Required_Security_Clearance_ID,Created_On,Created_By,Modified_On,Modified_By")] Contract_Position contract_Position)
        {
            if (ModelState.IsValid)
            {
                db.Contract_Positions.Add(contract_Position);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Info_Risk_ID = new SelectList(db.Adm_Info_Risks, "ID", "Info_Risk", contract_Position.Info_Risk_ID);
            ViewBag.Requisition_Status_ID = new SelectList(db.Adm_Requisition_Status, "ID", "Status", contract_Position.Requisition_Status_ID);
            ViewBag.Required_Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance", contract_Position.Required_Security_Clearance_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", contract_Position.Contract_ID);
            ViewBag.Contract_ID = new SelectList(db.Contract_WBS, "ID", "Area", contract_Position.Contract_ID);
            ViewBag.LCAT_ID = new SelectList(db.Ref_Contract_LCATs, "ID", "ESF_LCAT", contract_Position.LCAT_ID);
            ViewBag.Role_ID = new SelectList(db.Ref_Roles, "ID", "Role", contract_Position.Role_ID);
            return View(contract_Position);
        }

        // GET: Contract_Position/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract_Position contract_Position = db.Contract_Positions.Find(id);
            if (contract_Position == null)
            {
                return HttpNotFound();
            }
            ViewBag.Info_Risk_ID = new SelectList(db.Adm_Info_Risks, "ID", "Info_Risk", contract_Position.Info_Risk_ID);
            ViewBag.Requisition_Status_ID = new SelectList(db.Adm_Requisition_Status, "ID", "Status", contract_Position.Requisition_Status_ID);
            ViewBag.Required_Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance", contract_Position.Required_Security_Clearance_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", contract_Position.Contract_ID);
            ViewBag.Contract_ID = new SelectList(db.Contract_WBS, "ID", "Area", contract_Position.Contract_ID);
            ViewBag.LCAT_ID = new SelectList(db.Ref_Contract_LCATs, "ID", "ESF_LCAT", contract_Position.LCAT_ID);
            ViewBag.Role_ID = new SelectList(db.Ref_Roles, "ID", "Role", contract_Position.Role_ID);
            return View(contract_Position);
        }

        // POST: Contract_Position/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_ID,Role_ID,Contract_WBS_ID,Position__,Info_Risk_ID,LCAT_ID,DateNeeded,Requisition_Status_ID,Required_Security_Clearance_ID,Created_On,Created_By,Modified_On,Modified_By")] Contract_Position contract_Position)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contract_Position).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Info_Risk_ID = new SelectList(db.Adm_Info_Risks, "ID", "Info_Risk", contract_Position.Info_Risk_ID);
            ViewBag.Requisition_Status_ID = new SelectList(db.Adm_Requisition_Status, "ID", "Status", contract_Position.Requisition_Status_ID);
            ViewBag.Required_Security_Clearance_ID = new SelectList(db.Adm_Security_Clearances, "ID", "Security_Clearance", contract_Position.Required_Security_Clearance_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Created_By", contract_Position.Contract_ID);
            ViewBag.Contract_ID = new SelectList(db.Contract_WBS, "ID", "Area", contract_Position.Contract_ID);
            ViewBag.LCAT_ID = new SelectList(db.Ref_Contract_LCATs, "ID", "ESF_LCAT", contract_Position.LCAT_ID);
            ViewBag.Role_ID = new SelectList(db.Ref_Roles, "ID", "Role", contract_Position.Role_ID);
            return View(contract_Position);
        }

        // GET: Contract_Position/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract_Position contract_Position = db.Contract_Positions.Find(id);
            if (contract_Position == null)
            {
                return HttpNotFound();
            }
            return View(contract_Position);
        }

        // POST: Contract_Position/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contract_Position contract_Position = db.Contract_Positions.Find(id);
            db.Contract_Positions.Remove(contract_Position);
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
