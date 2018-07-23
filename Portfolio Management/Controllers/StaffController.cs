using System;
using System.Collections.Generic;
//using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
using System.Diagnostics;
using Portfolio_Management.CustomFilters;

namespace Portfolio_Management.Controllers
{
    [Authorize]
    public class StaffController : ApplicationBaseController
    {

        private PMDataEntities db = new PMDataEntities();
        //private StaffDashboardViewModel StaffDashboardVM = new StaffDashboardViewModel();

        // GET: Staff
        public ActionResult Index(/*string searchString*/)
        {

            //var staffs = db.Staffs.Include(s => s.Adm_Exit_Reason).Include(s => s.Adm_Prefix).Include(s => s.Adm_Suffix).Include(s => s.Ref_Company).Include(s => s.Staff_Clearance);
            //Breaks datatable integration with index in url 
            //List<Staff> staffList = new List<Staff>();

            //staffList = staffs.ToList();
            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    foreach (var user in staffs.ToList())
            //    {
            //        //if user doesn't match search string, remove them from user list to show
            //        if (!user.First_Name.Contains(searchString) && !user.Last_Name.Contains(searchString) &&
            //            !user.Staff_Name.Contains(searchString))
            //            staffList.Remove(user);
            //    }
            //}
            StaffDashboardViewModel StaffDashboardVM = new StaffDashboardViewModel();

            //AllStaffData.Staff = staffs.ToList();

            return View(StaffDashboardVM);
        }

        public ActionResult IndexO(StaffDashboardViewModel sdVM)
        {
            var staffs = db.Staffs.Include(s => s.Adm_Exit_Reason).Include(s => s.Adm_Prefix).Include(s => s.Adm_Suffix).Include(s => s.Ref_Company).Include(s => s.Staff_Clearance);

            if (sdVM.AllStaffData.Staff == null)
            {
                sdVM.AllStaffData.Staff = staffs.ToList();
            }

            return View("Index", sdVM);
        }

        [HttpGet]
        public ActionResult Action(int? id)
        {
            StaffActionsViewModel staffActionsVM = new StaffActionsViewModel();

            if (id == null)
            {
                staffActionsVM.IsStaffSelected = false;
                ViewBag.selectStaffError = "Choose a staff member to work with below";
                return RedirectToAction("Index");
            }

            staffActionsVM.StaffSelected = db.Staffs.Find(id);
            staffActionsVM.IsStaffSelected = true;
            //StaffEducationAction(staffActionsVM);

            return View(staffActionsVM);
        }

        public ActionResult StaffEducationAction(int? id)
        {
            StaffDashboardViewModel StaffDashboardVM = new StaffDashboardViewModel();
            if (id != null)
            {

                StaffDashboardVM.SelectedStaffData.Staff = db.Staffs.Find(id);
                foreach (var education in StaffDashboardVM.SelectedStaffData.Staff.Educations)
                {
                    StaffDashboardVM.SelectedStaffData.StaffEducations.Add(education);
                }
            }

            return PartialView("_StaffEducationAction", StaffDashboardVM);
        }


        //public ActionResult StaffSkillAction(int? id)
        //{
        //    if (id != null) //could this action be called without an id sent as a parameter? If so, we need to account for this possibility
        //    {
        //        StaffDashboardVM.SelectedStaffData.Staff = db.Staffs.Find(id); //find staff using selected id from table row click

        //        //Load user's CURRENT skills
        //        foreach (var skill in StaffDashboardVM.SelectedStaffData.Staff.Staff_Skill)
        //        {
        //            StaffDashboardVM.SelectedStaffData.StaffSkills.Add(skill);
        //        }

        //        //Load all skills available
        //        foreach (var ref_skill in db.Ref_Skills)
        //        {

        //            StaffDashboardVM.AllSkillsData.Skills.Add(ref_skill);

        //        }

        //        //The models Staff_Skill and Ref_Skills already contain the Proficiency Navigation property - This is not needed as a result
        //        //foreach (var adm_prof in db.Adm_Proficiencies)
        //        //{
        //        //    StaffDashboardVM.AllSkillsData.Proficiencies.Add(adm_prof);
        //        //}


        //        //This is a duplicate of above code
        //        //List<int> skillList = new List<int>();
        //        //foreach (var item in db.Ref_Skills)
        //        //{
        //        //    skillList.Add(item.ID);
        //        //}

        //        //So is this
        //        //List<int> staffSkillList = new List<int>();
        //        //foreach (var item in StaffDashboardVM.SelectedStaffData.StaffSkills)
        //        //{
        //        //    staffSkillList.Add(item.Skill_ID);
        //        //}

        //        //I don't see what the purpose of this is
        //        //IEnumerable<int> diffSkillList = new List<int>();
        //        //diffSkillList = skillList.Except(staffSkillList);


        //        //public SelectList(IEnumerable items, string dataValueField, string dataTextField, object selectedValue, IEnumerable disabledValues);
        //        ViewBag.Skill_ID = new SelectList(db.Ref_Skills, "ID", "Skill");
        //        ViewBag.Proficiency_ID = new SelectList(db.Adm_Proficiencies, "Proficiency_ID", "Proficiency");
        //    }

        //    return PartialView("_StaffSkillAction", StaffDashboardVM);
        //}

        public ActionResult StaffPositionAction(int? id)
        {
            StaffDashboardViewModel StaffDashboardVM = new StaffDashboardViewModel();
            if (id != null)
            {
                StaffDashboardVM.SelectedStaffData.Staff = db.Staffs.Find(id);
                foreach (var position in StaffDashboardVM.SelectedStaffData.Staff.Staff_Position)
                {
                    StaffDashboardVM.SelectedStaffData.StaffPositions.Add(position);
                }
            }
            return PartialView("_StaffPositionAction", StaffDashboardVM);
        }

        public ActionResult StaffExitAction(StaffActionsViewModel staffActionsVM)
        {
            ViewBag.Exit_Reason_ID = new SelectList(db.Adm_Exit_Reasons, "ID", "Exit_Reason", null);

            return PartialView("_StaffExitAction", staffActionsVM);
        }

 
        public ActionResult StaffSkillAction(int? id)
        {
            StaffDashboardViewModel StaffDashboardVM = new StaffDashboardViewModel();
            if (id != null)
            {
                StaffDashboardVM.SelectedStaffData.Staff = db.Staffs.Find(id); //find staff using selected id from table row click

                //Load user's CURRENT skills
                foreach (var skill in StaffDashboardVM.SelectedStaffData.Staff.Staff_Skill)
                {
                    StaffDashboardVM.SelectedStaffData.StaffSkills.Add(skill);
                }
            }
            //StaffDashboardVM = GetManageStaffSkillModal(StaffDashboardVM);

            return PartialView("_StaffSkillAction", StaffDashboardVM);
        }


        [ChildActionOnly]
        private bool hasStaffSkillEntityChanged(Staff_Skill oldStaffSkill, ManageSkillViewModel newStaffSkill)
        {

            if (oldStaffSkill.Staff_ID != newStaffSkill.StaffID ||
                oldStaffSkill.Skill_ID != newStaffSkill.SkillID ||
                oldStaffSkill.Proficiency_ID != newStaffSkill.ProficiencyID
                //oldStaffSkill.Created_By != newStaffSkill. ||
                //oldStaffSkill.Created_On != newStaffSkill.Created_On ||
                //oldStaffSkill.Created_By != newStaffSkill.Created_By ||
                //oldStaffSkill.Modified_By != newStaffSkill.Modified_By ||
                //oldStaffSkill.Modified_On != newStaffSkill.Modified_On
                )
            {
                return true;
            }

            return false;
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

                //Create a view model, bind to properties
                ManageSkillViewModel manageSkillVM = new ManageSkillViewModel();
                
                manageSkillVM.SkillID = skill.ID;
                manageSkillVM.SkillName = skill.Skill; //skill.Staff_Skill.FirstOrDefault(x => x.Skill_ID == skill.ID).Ref_Skill.Skill;
                manageSkillVM.StaffID = sdVM.SelectedStaffData.Staff.ID; //Maybe should be doing a find of a staff's id (db.Staffs.Find(id)). 
                                                 //Are we sure we sure we will always be sent a valid id?
                manageSkillVM.StaffSkillRadioButtonID = skill.ID + ", " + sdVM.SelectedStaffData.Staff.ID; //Need unique model identifier for RadioButtonFor HtmlHelper

                //Get relevant skill data if user has the skill
                foreach (var mySkill in db.Staff_Skills.Where(x => x.Staff_ID == sdVM.SelectedStaffData.Staff.ID))
                {
                    if (mySkill.Skill_ID == skill.ID)
                    {
                        manageSkillVM.HasSkill = true;
                        manageSkillVM.ProficiencyID = db.Staff_Skills.FirstOrDefault(x => x.Skill_ID == skill.ID).Proficiency_ID; //skill.Staff_Skill.FirstOrDefault(x => x.Skill_ID == skill.ID).Proficiency_ID;
                        manageSkillVM.ProficiencyName = db.Staff_Skills.FirstOrDefault(x => x.Skill_ID == skill.ID).Adm_Proficiency.Proficiency; //skill.Staff_Skill.FirstOrDefault(x => x.Skill_ID == skill.ID).Adm_Proficiency.Proficiency;
                        manageSkillVM.ShowRemoveSKill = true;
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
                //Staff staff = db.Staffs
                //              .Include(x => x.Staff_Skill)
                //            .SingleOrDefault(x => x.ID == staffDashboardVM.SelectedStaffData.Staff.ID);
                
                //Iterate over all skills user may have added/modified
                foreach (var newStaffSkill in model.ManageSkillDataList)
                {
                    if (newStaffSkill.HasSkill == true && newStaffSkill.ShowRemoveSKill == false) //User modified skill
                    {
                        bool test = ModelState.IsValid;
                        Staff_Skill skillToAdd = new Staff_Skill();
                        skillToAdd = db.Staff_Skills.Where(x => x.Staff_ID == newStaffSkill.StaffID)
                            .Where(x => x.Skill_ID == newStaffSkill.SkillID)
                            .SingleOrDefault();

                        if(skillToAdd.Proficiency_ID != newStaffSkill.ProficiencyID)
                        {
                            skillToAdd.Proficiency_ID = newStaffSkill.ProficiencyID;
                            skillToAdd.Modified_By = getCurrentUserFullName();
                            skillToAdd.Modified_On = System.DateTime.Now;
                            db.Staff_Skills.Attach(skillToAdd);
                            var entry = db.Entry(skillToAdd);
                            entry.State = EntityState.Modified;
                        }
                    }
                    else if(newStaffSkill.HasSkill == true && newStaffSkill.ShowRemoveSKill == true)//User wants to remove skill
                    {
                        Staff_Skill skillToAdd = new Staff_Skill();
                        skillToAdd = db.Staff_Skills.Where(x => x.Staff_ID == newStaffSkill.StaffID)
                            .Where(x => x.Skill_ID == newStaffSkill.SkillID)
                            .SingleOrDefault();

                        db.Staff_Skills.Attach(skillToAdd);
                        db.Staff_Skills.Remove(skillToAdd);
                    }
                    else if(newStaffSkill.HasSkill == false)
                    {
                        if(newStaffSkill.ProficiencyID != 0) //New skill to add
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

                //newStaffSkill.Staff_ID = staffDashboardVM.SelectedStaffData.
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
            return View("Index",model);
        }

        public ActionResult Dashboard()
        {

            StaffDashboardViewModel staffDBVM = new StaffDashboardViewModel();
            staffDBVM.NumStaff = db.Staffs.Count();
            staffDBVM.CompanyChart = getCompanyChartData();

            return View(staffDBVM);
        }

        [ChildActionOnly]
        public List<StaffDashboardViewModel.CompanyData> getCompanyChartData()
        {
            //ADD: total companies
            List<StaffDashboardViewModel.CompanyData> companyDataList = new List<StaffDashboardViewModel.CompanyData>();

            foreach (var company in db.Ref_Companies.ToList())
            {
                StaffDashboardViewModel.CompanyData companyData = new StaffDashboardViewModel.CompanyData();
                companyData.CompanyID = company.ID;
                companyData.CompanyName = company.Company;

                foreach (var staff in db.Staffs.ToList())
                {
                    if (company.ID == staff.Company_ID)
                    {
                        companyData.ShareOfWorkforce++;
                    }
                }
                companyDataList.Add(companyData);
            }
            return companyDataList;
        }

        public bool isActionAvailableForUser(int id)
        {
            var usersInDB = getCompanyChartData();
            return false;
        }

        //[AuthLog(Roles = "User")]
        public ActionResult ManagerMetrics(string test)
        {
            StaffManagerViewModel smVM = new StaffManagerViewModel();
            smVM.StaffName = User.Identity.Name;
            smVM.test = test;
            return PartialView("_ManagerMetricsView", smVM);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        public ActionResult ContactList(string searchString)
        {
            ContactListViewModel clVM = new ContactListViewModel();

            clVM.Staffs = db.Staffs.ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                foreach (var user in db.Staffs.ToList())
                {
                    //if user doesn't match search string, remove them from user list to show
                    if (!user.Staff_Name.Contains(searchString) && !user.Company_Email.Contains(searchString))
                    //&& !user.Cell_Phone.Contains(searchString) && !user.Personal_Cell_Phone.Contains(searchString)
                    //&&!user.Desk_Phone.Contains(searchString))
                    {
                        clVM.Staffs.Remove(user);
                    }
                }
            }
            return View("_ContactListView", clVM);
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            ViewBag.Exit_Reason_ID = new SelectList(db.Adm_Exit_Reasons, "ID", "Exit_Reason", null);
            ViewBag.Prefix = new SelectList(db.Adm_Prefixes, "Prefix", "Prefix", null);
            ViewBag.Suffix = new SelectList(db.Adm_Suffixes, "Suffix", "Suffix", null);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", null);
            ViewBag.ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", null);
            return View();
        }



        // POST: Staff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Person_Key,Company_ID,Staff_Name,Prefix,Last_Name,First_Name,Middle_Initial,Suffix,Alias,Location,Cell_Phone,Personal_Cell_Phone,Desk_Phone,Company_Email,IsForeign_National,IsBillable,Years_of_Experience,Hire_Date,Exit_Date,Exit_Note,Exit_Reason_ID,Is_Eligible_for_Rehire,Created_On,Created_By,Modified_On,Modified_By")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Exit_Reason_ID = new SelectList(db.Adm_Exit_Reasons, "ID", "Exit_Reason", staff.Exit_Reason_ID);
            ViewBag.Prefix = new SelectList(db.Adm_Prefixes, "Prefix", "Prefix", staff.Prefix);
            ViewBag.Suffix = new SelectList(db.Adm_Suffixes, "Suffix", "Suffix", staff.Suffix);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", staff.Company_ID);
            ViewBag.ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", staff.ID);
            return View(staff);
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            ViewBag.Exit_Reason_ID = new SelectList(db.Adm_Exit_Reasons, "ID", "Exit_Reason", staff.Exit_Reason_ID);
            ViewBag.Prefix = new SelectList(db.Adm_Prefixes, "Prefix", "Prefix", staff.Prefix);
            ViewBag.Suffix = new SelectList(db.Adm_Suffixes, "Suffix", "Suffix", staff.Suffix);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", staff.Company_ID);
            ViewBag.ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", staff.ID);
            return View(staff);
        }

        // POST: Staff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Person_Key,Company_ID,Staff_Name,Prefix,Last_Name,First_Name,Middle_Initial,Suffix,Alias,Location,Cell_Phone,Personal_Cell_Phone,Desk_Phone,Company_Email,IsForeign_National,IsBillable,Years_of_Experience,Hire_Date,Exit_Date,Exit_Note,Exit_Reason_ID,Is_Eligible_for_Rehire,Created_On,Created_By,Modified_On,Modified_By")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Exit_Reason_ID = new SelectList(db.Adm_Exit_Reasons, "ID", "Exit_Reason", staff.Exit_Reason_ID);
            ViewBag.Prefix = new SelectList(db.Adm_Prefixes, "Prefix", "Prefix", staff.Prefix);
            ViewBag.Suffix = new SelectList(db.Adm_Suffixes, "Suffix", "Suffix", staff.Suffix);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company", staff.Company_ID);
            ViewBag.ID = new SelectList(db.Staff_Clearances, "ID", "Created_By", staff.ID);
            return View(staff);
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.Staffs.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff staff = db.Staffs.Find(id);
            db.Staffs.Remove(staff);
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
