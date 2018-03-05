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
    public class Ref_SkillController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Ref_Skill
        public ActionResult Index()
        {
            return View(db.Ref_Skills.ToList());
        }

        // GET: Ref_Skill/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Skill ref_Skill = db.Ref_Skills.Find(id);
            if (ref_Skill == null)
            {
                return HttpNotFound();
            }
            return View(ref_Skill);
        }

        // GET: Ref_Skill/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ref_Skill/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Skill")] Ref_Skill ref_Skill)
        {
            if (ModelState.IsValid)
            {
                db.Ref_Skills.Add(ref_Skill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ref_Skill);
        }

        // GET: Ref_Skill/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Skill ref_Skill = db.Ref_Skills.Find(id);
            if (ref_Skill == null)
            {
                return HttpNotFound();
            }
            return View(ref_Skill);
        }

        // POST: Ref_Skill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Skill")] Ref_Skill ref_Skill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ref_Skill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ref_Skill);
        }

        // GET: Ref_Skill/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ref_Skill ref_Skill = db.Ref_Skills.Find(id);
            if (ref_Skill == null)
            {
                return HttpNotFound();
            }
            return View(ref_Skill);
        }

        // POST: Ref_Skill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ref_Skill ref_Skill = db.Ref_Skills.Find(id);
            db.Ref_Skills.Remove(ref_Skill);
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
