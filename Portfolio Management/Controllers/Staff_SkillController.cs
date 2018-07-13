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
                ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", id);
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

            ViewBag.DateTime = DateTime.Now;
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

        // POST: Staff_Skill/SkillModalSubmit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SkillModalSubmit(StaffDashboardViewModel staffVM) //(int staff_id, List<int> skill_ids, List<int> prof_ids)
        {
            if (ModelState.IsValid)
            {
                var original = db.Staff_Skills.Where(x=>x.Staff_ID == staffVM.SelectedStaffData.Staff.ID).ToList();//get current staff_skills list for staff member from db
                var originalIDs = new List<int>();
                for (int i=0; i<original.Count; i++)
                {
                    originalIDs.Add(original[i].Skill_ID);//populate list of skill ids to compare by id
                }
                for (int i=0; i<original.Count; i++)
                {
                    //if (!original.Contains(staffVM.StaffSkills[i]))
                    if (!originalIDs.Contains(staffVM.SelectedStaffData.StaffSkills[i].Skill_ID)) //new ID detected
                    {
                        //altered.Add(staffVM.StaffSkills[i].Skill_ID);
                        db.Staff_Skills.Add(staffVM.SelectedStaffData.StaffSkills[i]);
                    }
                    //else if ()
                    else //possible modified entry
                    {
                        //db.Entry(original.Find(staffVM.StaffSkills[i]).CurrentValues.SetValues(staffVM.StaffSkills[i]);
                    }
                }
                //db.Entry(original[i]).CurrentValues.SetValues
                //original.StartDate = project.StartDate;
                //original.Duration = project.Duration;
                //doSomething();
                //db.Entry(original).CurrentValues.SetValues(project);
                db.SaveChanges();
            }
            return View(staffVM);
            //for (int i = 0; i < skill_ids.Count; i++)
            //{
            //Staff_Skill staff_Skill = db.Staff_Skills.Find(staff_id, skill_ids[i]);
            //if ()
            //}
            //return RedirectToAction("Index");
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