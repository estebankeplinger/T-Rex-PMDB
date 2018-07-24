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

        [HttpGet]
        public ActionResult ManageStaffSkillModal(int id)
        {
            StaffDashboardViewModel sdVM = new StaffDashboardViewModel();
            sdVM.SelectedStaffData.Staff = db.Staffs.Find(id);

            //Load all proficiencies
            foreach (var proficiency in db.Adm_Proficiencies)
            {
                sdVM.AllSkillsData.Proficiencies.Add(proficiency);
            }

            //For each skill in the list of ALL skills
            foreach (var skill in db.Ref_Skills)
            {
                sdVM.AllSkillsData.Skills.Add(skill);

                //Create a view model, map to properties in Ref_Skills
                ManageSkillViewModel manageSkillVM = new ManageSkillViewModel();
                manageSkillVM.SkillID = skill.ID;
                manageSkillVM.SkillName = skill.Skill;
                manageSkillVM.StaffID = sdVM.SelectedStaffData.Staff.ID;
                manageSkillVM.StaffSkillRadioButtonID = skill.ID + ", " + sdVM.SelectedStaffData.Staff.ID;

                //Get relevant skill data if user has the skill
                foreach (var mySkill in db.Staff_Skills.Where(x => x.Staff_ID == sdVM.SelectedStaffData.Staff.ID))
                {
                    if (mySkill.Skill_ID == skill.ID)
                    {
                        manageSkillVM.HasSkill = true;
                        manageSkillVM.ProficiencyID = db.Staff_Skills.FirstOrDefault(x => x.Skill_ID == skill.ID).Proficiency_ID;
                        manageSkillVM.ProficiencyName = db.Staff_Skills.FirstOrDefault(x => x.Skill_ID == skill.ID).Adm_Proficiency.Proficiency;
                        manageSkillVM.RemoveSKill = false;
                    }
                }

                sdVM.ManageSkillDataList.Add(manageSkillVM); //Add view model to list of view models
            }

            return PartialView("_SkillModal", sdVM);
        }
        // StaffSkillAction: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManageStaffSkillModal(StaffDashboardViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Iterate over all skills user may have added/modified using client-filled form data
                foreach (var newStaffSkill in model.ManageSkillDataList)
                {
                    if (newStaffSkill.HasSkill == true && newStaffSkill.RemoveSKill == false) //User modified skill
                    {
                        bool test = ModelState.IsValid;
                        Staff_Skill skillToAdd = new Staff_Skill();
                        skillToAdd = db.Staff_Skills.Where(x => x.Staff_ID == newStaffSkill.StaffID)
                            .Where(x => x.Skill_ID == newStaffSkill.SkillID)
                            .SingleOrDefault();

                        if (skillToAdd.Proficiency_ID != newStaffSkill.ProficiencyID)
                        {
                            skillToAdd.Proficiency_ID = newStaffSkill.ProficiencyID;
                            skillToAdd.Modified_By = getCurrentUserFullName();
                            skillToAdd.Modified_On = System.DateTime.Now;
                            db.Staff_Skills.Attach(skillToAdd);
                            var entry = db.Entry(skillToAdd);
                            entry.State = EntityState.Modified;
                        }
                    }
                    //User wants to remove skill
                    else if (newStaffSkill.HasSkill == true && newStaffSkill.RemoveSKill == true)
                    {
                        Staff_Skill skillToAdd = new Staff_Skill();
                        skillToAdd = db.Staff_Skills.Where(x => x.Staff_ID == newStaffSkill.StaffID)
                            .Where(x => x.Skill_ID == newStaffSkill.SkillID)
                            .SingleOrDefault();

                        db.Staff_Skills.Attach(skillToAdd);
                        db.Staff_Skills.Remove(skillToAdd);
                    }
                    else if (newStaffSkill.HasSkill == false)
                    {
                        //New skill to add
                        if (newStaffSkill.ProficiencyID != 0) 
                        {
                            Staff_Skill newSkill = new Staff_Skill();
                            newSkill.Skill_ID = newStaffSkill.SkillID;
                            newSkill.Staff_ID = newStaffSkill.StaffID;
                            newSkill.Proficiency_ID = newStaffSkill.ProficiencyID;
                            newSkill.Created_By = getCurrentUserFullName();
                            newSkill.Created_On = System.DateTime.Now;
                            newSkill.Modified_By = getCurrentUserFullName();
                            newSkill.Modified_On = System.DateTime.Now;

                            db.Staff_Skills.Add(newSkill);
                        }
                    }
                }
            }
            else
            {
                List<string> modelStateErrors = new List<string>();
                foreach (ModelState modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        modelStateErrors.Add(error.ErrorMessage);
                    }
                }
            }

            db.SaveChanges();
            return RedirectToAction("Index","Staff");
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