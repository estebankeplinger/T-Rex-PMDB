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
    public class Staff_Clearance_WorkflowController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Staff_Clearance_Workflow
        public ActionResult Index()
        {
            var staff_Clearance_Workflows = db.Staff_Clearance_Workflows.Include(s => s.Security_Workflow).Include(s => s.Staff_Clearance);
            return View(staff_Clearance_Workflows.ToList());
        }

        // GET: Staff_Clearance_Workflow/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Clearance_Workflow staff_Clearance_Workflow = db.Staff_Clearance_Workflows.Find(id);
            if (staff_Clearance_Workflow == null)
            {
                return HttpNotFound();
            }
            return View(staff_Clearance_Workflow);
        }

        // GET: Staff_Clearance_Workflow/Create
        public ActionResult Create()
        {
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Security_Workflow_ID = new SelectList(db.Security_Workflows, "ID", "Workflow");
            ViewBag.Staff_Clearance_ID = new SelectList(db.Staff_Clearances, "ID", "Created_By");
            return View();
        }

        // POST: Staff_Clearance_Workflow/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_Clearance_ID,Security_Workflow_ID,Is_Active,Entry_Date,Exit_Date,Created_On,Created_By,Modified_On,Modified_By")] Staff_Clearance_Workflow staff_Clearance_Workflow)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Clearance_Workflows.Add(staff_Clearance_Workflow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Security_Workflow_ID = new SelectList(db.Security_Workflows, "ID", "Workflow", staff_Clearance_Workflow.Security_Workflow_ID);
            ViewBag.Staff_Clearance_ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", staff_Clearance_Workflow.Staff_Clearance_ID);
            return View(staff_Clearance_Workflow);
        }

        // GET: Staff_Clearance_Workflow/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Clearance_Workflow staff_Clearance_Workflow = db.Staff_Clearance_Workflows.Find(id);
            if (staff_Clearance_Workflow == null)
            {
                return HttpNotFound();
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Security_Workflow_ID = new SelectList(db.Security_Workflows, "ID", "Workflow", staff_Clearance_Workflow.Security_Workflow_ID);
            ViewBag.Staff_Clearance_ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", staff_Clearance_Workflow.Staff_Clearance_ID);
            return View(staff_Clearance_Workflow);
        }

        // POST: Staff_Clearance_Workflow/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_Clearance_ID,Security_Workflow_ID,Is_Active,Entry_Date,Exit_Date,Created_On,Created_By,Modified_On,Modified_By")] Staff_Clearance_Workflow staff_Clearance_Workflow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Clearance_Workflow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Security_Workflow_ID = new SelectList(db.Security_Workflows, "ID", "Workflow", staff_Clearance_Workflow.Security_Workflow_ID);
            ViewBag.Staff_Clearance_ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", staff_Clearance_Workflow.Staff_Clearance_ID);
            return View(staff_Clearance_Workflow);
        }

        // GET: Staff_Clearance_Workflow/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Clearance_Workflow staff_Clearance_Workflow = db.Staff_Clearance_Workflows.Find(id);
            if (staff_Clearance_Workflow == null)
            {
                return HttpNotFound();
            }
            return View(staff_Clearance_Workflow);
        }

        // POST: Staff_Clearance_Workflow/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff_Clearance_Workflow staff_Clearance_Workflow = db.Staff_Clearance_Workflows.Find(id);
            db.Staff_Clearance_Workflows.Remove(staff_Clearance_Workflow);
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
