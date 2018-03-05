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
    public class ContractsController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Contracts
        public ActionResult Index()
        {
            var contracts = db.Contracts.Include(c => c.Ref_Customer).Include(c => c.Staff);
            return View(contracts.ToList());
        }

        // GET: Contracts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // GET: Contracts/Create
        public ActionResult Create()
        {
            ViewBag.Customer_ID = new SelectList(db.Ref_Customers, "ID", "Customer");
            ViewBag.Program_Manager_ID = new SelectList(db.Staffs, "ID", "Staff_Name");
            return View();
        }

        // POST: Contracts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Customer_ID,POP_Start,POP_End,Program_Manager_ID,IsPrime,FillByDuration,Created_On,Created_By,Modified_On,Modified_By")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                db.Contracts.Add(contract);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Customer_ID = new SelectList(db.Ref_Customers, "ID", "Customer", contract.Customer_ID);
            ViewBag.Program_Manager_ID = new SelectList(db.Staffs, "ID", "Staff_Name", contract.Program_Manager_ID);
            return View(contract);
        }

        // GET: Contracts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            ViewBag.Customer_ID = new SelectList(db.Ref_Customers, "ID", "Customer", contract.Customer_ID);
            ViewBag.Program_Manager_ID = new SelectList(db.Staffs, "ID", "Staff_Name", contract.Program_Manager_ID);
            return View(contract);
        }

        // POST: Contracts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Customer_ID,POP_Start,POP_End,Program_Manager_ID,IsPrime,FillByDuration,Created_On,Created_By,Modified_On,Modified_By")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contract).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Customer_ID = new SelectList(db.Ref_Customers, "ID", "Customer", contract.Customer_ID);
            ViewBag.Program_Manager_ID = new SelectList(db.Staffs, "ID", "Staff_Name", contract.Program_Manager_ID);
            return View(contract);
        }

        // GET: Contracts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // POST: Contracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contract contract = db.Contracts.Find(id);
            db.Contracts.Remove(contract);
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
