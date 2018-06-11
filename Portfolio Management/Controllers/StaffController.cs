﻿using System;
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
        private StaffDashboardViewModel StaffDashboardVM = new StaffDashboardViewModel();

        // GET: Staff
        public ActionResult Index(/*string searchString*/)
        {

            var staffs = db.Staffs.Include(s => s.Adm_Exit_Reason).Include(s => s.Adm_Prefix).Include(s => s.Adm_Suffix).Include(s => s.Ref_Company).Include(s => s.Staff_Clearance);
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

            
            StaffDashboardVM.AllStaffData.Staff = staffs.ToList();

            return View(StaffDashboardVM);
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

        public ActionResult StaffSkillAction(int? id)
        {
            if (id != null)
            {
                StaffDashboardVM.SelectedStaffData.Staff = db.Staffs.Find(id);
                foreach(var skill in StaffDashboardVM.SelectedStaffData.Staff.Staff_Skill)
                {
                    StaffDashboardVM.SelectedStaffData.StaffSkills.Add(skill);
                }
            }

            return PartialView("_StaffSkillAction", StaffDashboardVM);
        }

        public ActionResult StaffPositionAction(int? id)
        {
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
            ViewBag.Exit_Reason_ID = new SelectList(db.Adm_Exit_Reasons, "ID", "Exit_Reason",null);
            ViewBag.Prefix = new SelectList(db.Adm_Prefixes, "Prefix", "Prefix",null);
            ViewBag.Suffix = new SelectList(db.Adm_Suffixes, "Suffix", "Suffix",null);
            ViewBag.Company_ID = new SelectList(db.Ref_Companies, "ID", "Company",null);
            ViewBag.ID = new SelectList(db.Staff_Clearances, "ID", "Created_By",null);
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
