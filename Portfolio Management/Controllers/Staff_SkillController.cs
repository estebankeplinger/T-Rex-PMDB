using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
using Microsoft.AspNet.Identity;

using System.Diagnostics;

namespace Portfolio_Management.Controllers
{
    public class Staff_SkillController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        // GET: Staff_Skill
        public ActionResult Index()
        {
            var staff_Skills = db.Staff_Skills.Include(s => s.Adm_Proficiency).Include(s => s.Ref_Skill).Include(s => s.Staff);
            return View(staff_Skills.ToList());
        }

        // GET: Staff_Skill/Details/5
        public ActionResult Details(int? staff_id, int? skill_id)
        {
            if (staff_id == null || skill_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Skill staff_Skill = db.Staff_Skills.Find(staff_id, skill_id);
            if (staff_Skill == null)
            {
                return HttpNotFound();
            }
            return View(staff_Skill);
        }

        // GET: Staff_Skill/Create
        public ActionResult Create(int? id)
        {
            ViewBag.Proficiency_ID = new SelectList(db.Adm_Proficiencies, "Proficiency_ID", "Proficiency");
            ViewBag.Skill_ID = new SelectList(db.Ref_Skills, "ID", "Skill");
            if (ModelState.IsValid && id != null)
                ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name",id);        
            else
                ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");

            ViewBag.DateTime = DateTime.Now;
            return View();
        }

        // POST: Staff_Skill/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Staff_ID,Skill_ID,Proficiency_ID,Created_On,Created_By,Modified_On,Modified_By")] Staff_Skill staff_Skill)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Skills.Add(staff_Skill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Proficiency_ID = new SelectList(db.Adm_Proficiencies, "Proficiency_ID", "Proficiency", staff_Skill.Proficiency_ID);
            ViewBag.Skill_ID = new SelectList(db.Ref_Skills, "ID", "Skill", staff_Skill.Skill_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Skill.Staff_ID);
            return View(staff_Skill);
        }

        // GET: Staff_Skill/Edit/5
        public ActionResult Edit(int? staff_id, int? skill_id)
        {
            //int staffID;

            if (staff_id == null || skill_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //staffID = (int) id;
            Staff_Skill staff_Skill = db.Staff_Skills.Include(x => x.Staff.Staff_Skill).SingleOrDefault(x => x.Staff_ID == staff_id && x.Skill_ID == skill_id);
            //Staff_Skill staff_Skill = db.Staff_Skills.SingleOrDefault(x => x.Staff_ID == id);
            if (staff_Skill == null)
            {
                return HttpNotFound();
            }
            ViewBag.Proficiency_ID = new SelectList(db.Adm_Proficiencies, "Proficiency_ID", "Proficiency", staff_Skill.Proficiency_ID);
            ViewBag.Skill_ID = new SelectList(db.Ref_Skills, "ID", "Skill", staff_Skill.Skill_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Skill.Staff_ID);
            return View(staff_Skill);
        }

        // POST: Staff_Skill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Staff_ID,Skill_ID,Proficiency_ID,Created_On,Created_By,Modified_On,Modified_By")] Staff_Skill staff_Skill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Skill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Proficiency_ID = new SelectList(db.Adm_Proficiencies, "Proficiency_ID", "Proficiency", staff_Skill.Proficiency_ID);
            ViewBag.Skill_ID = new SelectList(db.Ref_Skills, "ID", "Skill", staff_Skill.Skill_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", staff_Skill.Staff_ID);
            return View(staff_Skill);
        }

        // GET: Staff_Skill/Delete/5
        public ActionResult Delete(int? staff_id, int? skill_id)
        {
            if (staff_id == null || skill_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Skill staff_Skill = db.Staff_Skills.Find(staff_id, skill_id);
            if (staff_Skill == null)
            {
                return HttpNotFound();
            }
            return View(staff_Skill);
        }

        // POST: Staff_Skill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int staff_id, int skill_id)
        {
            Staff_Skill staff_Skill = db.Staff_Skills.Find(staff_id, skill_id);
            db.Staff_Skills.Remove(staff_Skill);
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
