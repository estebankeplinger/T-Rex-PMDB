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
    public class Position_ForecastController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Position_Forecast
        public ActionResult Index()
        {
            var position_Forecasts = db.Position_Forecasts.Include(p => p.Contract_Position).Include(p => p.Ref_Pay_Period);
            return View(position_Forecasts.ToList());
        }

        // GET: Position_Forecast/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position_Forecast position_Forecast = db.Position_Forecasts.Find(id);
            if (position_Forecast == null)
            {
                return HttpNotFound();
            }
            return View(position_Forecast);
        }

        // GET: Position_Forecast/Create
        public ActionResult Create()
        {
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID");
            ViewBag.Pay_Period_ID = new SelectList(db.Ref_Pay_Periods, "ID", "ID");
            return View();
        }

        // POST: Position_Forecast/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Contract_Position_ID,Pay_Period_ID,FTE,Hours,Created_On,Created_By,Modified_On,Modified_By")] Position_Forecast position_Forecast)
        {
            if (ModelState.IsValid)
            {
                db.Position_Forecasts.Add(position_Forecast);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", position_Forecast.Contract_Position_ID);
            ViewBag.Pay_Period_ID = new SelectList(db.Ref_Pay_Periods, "ID", "ID", position_Forecast.Pay_Period_ID);
            return View(position_Forecast);
        }

        // GET: Position_Forecast/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position_Forecast position_Forecast = db.Position_Forecasts.Find(id);
            if (position_Forecast == null)
            {
                return HttpNotFound();
            }
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", position_Forecast.Contract_Position_ID);
            ViewBag.Pay_Period_ID = new SelectList(db.Ref_Pay_Periods, "ID", "ID", position_Forecast.Pay_Period_ID);
            return View(position_Forecast);
        }

        // POST: Position_Forecast/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Contract_Position_ID,Pay_Period_ID,FTE,Hours,Created_On,Created_By,Modified_On,Modified_By")] Position_Forecast position_Forecast)
        {
            if (ModelState.IsValid)
            {
                db.Entry(position_Forecast).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contract_Position_ID = new SelectList(db.Contract_Positions, "ID", "Contract_WBS_ID", position_Forecast.Contract_Position_ID);
            ViewBag.Pay_Period_ID = new SelectList(db.Ref_Pay_Periods, "ID", "ID", position_Forecast.Pay_Period_ID);
            return View(position_Forecast);
        }

        // GET: Position_Forecast/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Position_Forecast position_Forecast = db.Position_Forecasts.Find(id);
            if (position_Forecast == null)
            {
                return HttpNotFound();
            }
            return View(position_Forecast);
        }

        // POST: Position_Forecast/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Position_Forecast position_Forecast = db.Position_Forecasts.Find(id);
            db.Position_Forecasts.Remove(position_Forecast);
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
