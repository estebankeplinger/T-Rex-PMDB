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
    public class Contract_WBController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Contract_WB
        public ActionResult Index()
        {
            return View(db.Contract_WBS.ToList());
        }

        // GET: Contract_WB/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract_WB contract_WB = db.Contract_WBS.Find(id);
            if (contract_WB == null)
            {
                return HttpNotFound();
            }
            return View(contract_WB);
        }

        // GET: Contract_WB/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contract_WB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_ID,Area,Level_1,Level_2,Level_3,Level_4,Level_5,Created_On,Created_By,Modified_On,Modified_By")] Contract_WB contract_WB)
        {
            if (ModelState.IsValid)
            {
                db.Contract_WBS.Add(contract_WB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contract_WB);
        }

        // GET: Contract_WB/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract_WB contract_WB = db.Contract_WBS.Find(id);
            if (contract_WB == null)
            {
                return HttpNotFound();
            }
            return View(contract_WB);
        }

        // POST: Contract_WB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_ID,Area,Level_1,Level_2,Level_3,Level_4,Level_5,Created_On,Created_By,Modified_On,Modified_By")] Contract_WB contract_WB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contract_WB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contract_WB);
        }

        // GET: Contract_WB/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract_WB contract_WB = db.Contract_WBS.Find(id);
            if (contract_WB == null)
            {
                return HttpNotFound();
            }
            return View(contract_WB);
        }

        // POST: Contract_WB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contract_WB contract_WB = db.Contract_WBS.Find(id);
            db.Contract_WBS.Remove(contract_WB);
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
