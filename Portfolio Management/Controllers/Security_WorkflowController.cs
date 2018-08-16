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
    public class Security_WorkflowController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Security_Workflow
        public ActionResult Index()
        {
            var security_Workflows = db.Security_Workflows.Include(s => s.Adm_Clearance_Status).Include(s => s.Contract);
            return View(security_Workflows.ToList());
        }

        // GET: Security_Workflow/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Security_Workflow security_Workflow = db.Security_Workflows.Find(id);
            if (security_Workflow == null)
            {
                return HttpNotFound();
            }
            return View(security_Workflow);
        }

        // GET: Security_Workflow/Create
        public ActionResult Create()
        {
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Clearance_Status_ID = new SelectList(db.Adm_Clearance_Status, "ID", "Clearance_Status");
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title");
            return View();
        }

        // POST: Security_Workflow/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_ID,Display_Order,Workflow,Always_Display,Clearance_Status_ID,Created_On,Created_By,Modified_On,Modified_By")] Security_Workflow security_Workflow)
        {
            if (ModelState.IsValid)
            {
                db.Security_Workflows.Add(security_Workflow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Clearance_Status_ID = new SelectList(db.Adm_Clearance_Status, "ID", "Clearance_Status", security_Workflow.Clearance_Status_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", security_Workflow.Contract_ID);
            return View(security_Workflow);
        }

        // GET: Security_Workflow/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Security_Workflow security_Workflow = db.Security_Workflows.Find(id);
            if (security_Workflow == null)
            {
                return HttpNotFound();
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Clearance_Status_ID = new SelectList(db.Adm_Clearance_Status, "ID", "Clearance_Status", security_Workflow.Clearance_Status_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", security_Workflow.Contract_ID);
            return View(security_Workflow);
        }

        // POST: Security_Workflow/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_ID,Display_Order,Workflow,Always_Display,Clearance_Status_ID,Created_On,Created_By,Modified_On,Modified_By")] Security_Workflow security_Workflow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(security_Workflow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Clearance_Status_ID = new SelectList(db.Adm_Clearance_Status, "ID", "Clearance_Status", security_Workflow.Clearance_Status_ID);
            ViewBag.Contract_ID = new SelectList(db.Contracts, "ID", "Title", security_Workflow.Contract_ID);
            return View(security_Workflow);
        }

        // GET: Security_Workflow/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Security_Workflow security_Workflow = db.Security_Workflows.Find(id);
            if (security_Workflow == null)
            {
                return HttpNotFound();
            }
            return View(security_Workflow);
        }

        // POST: Security_Workflow/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Security_Workflow security_Workflow = db.Security_Workflows.Find(id);
            db.Security_Workflows.Remove(security_Workflow);
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
