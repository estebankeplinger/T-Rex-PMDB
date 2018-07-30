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
    public class EducationsController : ApplicationBaseController
    {
        private PMDataEntities db = new PMDataEntities();

        [HttpGet]
        public ActionResult ManageStaffEducationsModal(int id)
        {
            StaffDashboardViewModel sdVM = new StaffDashboardViewModel();
            sdVM.SelectedStaffData.Staff = db.Staffs.Find(id);
            int i = 0;

            //get user's educations
            List<Education> selectedStaffEducations = db.Educations.Include(x => x.Staff).Where(x => x.Staff_ID == sdVM.SelectedStaffData.Staff.ID).ToList();

            //Map user's educations to view model: ManageEducationsDataList
            foreach (var education in selectedStaffEducations)
            {
                ManageStaffEducationsViewModel manageEducationsVM = new ManageStaffEducationsViewModel();
                manageEducationsVM.StaffID = education.Staff_ID;
                manageEducationsVM.School = education.School;
                manageEducationsVM.DegreeID = education.Degree_ID;
                manageEducationsVM.CompletedDate = education.Completed_Date;
                manageEducationsVM.HasEducation = true;
                manageEducationsVM.RemoveEducation = false;
                manageEducationsVM.StaffName = education.Staff.Staff_Name;
                manageEducationsVM.EducationID = education.ID;
                manageEducationsVM.CurrentListIndex = i;
                manageEducationsVM.IsNewSkill = false;

                i++;
                sdVM.ManageEducationsDataList.Add(manageEducationsVM);
            }


            ViewBag.DegSelectList = new SelectList(db.Adm_Degrees, "ID", "Degree");
            ViewBag.ListDegrees = db.Adm_Degrees;

            return PartialView("_staffEducationsModal", sdVM);
        }

        public ActionResult addSingleEducation()
        {
            ViewBag.ListDegrees = db.Adm_Degrees;
            ViewBag.DegSelectList = new SelectList(db.Adm_Degrees, "ID", "Degree");

            ManageStaffEducationsViewModel newSEVM = new ManageStaffEducationsViewModel();
            newSEVM.IsNewSkill = true;
            return PartialView("_singleStaffEducation", newSEVM);
        }

        // StaffSkillAction: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManageStaffEducationsModal(StaffDashboardViewModel model)
        {
            string currentUserName = getCurrentUserFullName();
            DateTime currentTime = System.DateTime.Now;
            DateTime nullDateTimeValue = new DateTime(0001, 1, 1, 12, 0, 0);
            int dateCompareResult = 0;


            if (ModelState.IsValid)
            {
                //create copy of data while we enumerate through the model
                List<ManageStaffEducationsViewModel> postIteratorCopy = model.ManageEducationsDataList;

                foreach (var editedEducation in model.ManageEducationsDataList)
                {
                    //User wants to delete education
                    if (editedEducation.RemoveEducation == true)
                    {

                        if (editedEducation.HasEducation == true)
                        {
                            Education educationToFind = new Education();
                            educationToFind = db.Educations.Where(x => x.ID == editedEducation.EducationID).SingleOrDefault();

                            db.Educations.Attach(educationToFind);
                            db.Educations.Remove(educationToFind);
                        }
                        else
                        {

                            //don't look for database record
                            //just remove from list
                            if (editedEducation.IsNewSkill == true)
                            {
                                postIteratorCopy.Remove(editedEducation);
                            }
                        }
                    }//edited 7/27

                    //Check if user edited education
                    else if (editedEducation.HasEducation == true && editedEducation.RemoveEducation == false)
                    {
                        Education educationFoundFromDb = new Education();
                        educationFoundFromDb = db.Educations.Where(x => x.ID == editedEducation.EducationID).SingleOrDefault();

                        //User modified a field in their existing Educations
                        if (editedEducation.DegreeID != educationFoundFromDb.Degree_ID ||
                            editedEducation.School != educationFoundFromDb.School ||
                            editedEducation.CompletedDate != educationFoundFromDb.Completed_Date)
                        {
                            educationFoundFromDb.Degree_ID = editedEducation.DegreeID;
                            educationFoundFromDb.School = editedEducation.School;
                            educationFoundFromDb.Completed_Date = editedEducation.CompletedDate;
                            educationFoundFromDb.Staff_ID = editedEducation.StaffID;
                            educationFoundFromDb.Modified_By = currentUserName;
                            educationFoundFromDb.Modified_On = currentTime;

                            db.Educations.Attach(educationFoundFromDb);
                            var entry = db.Entry(educationFoundFromDb);
                            entry.State = EntityState.Modified;
                        }
                    }
                    else if (editedEducation.HasEducation == false)
                    {
                        //User added new Education
                        Education newEducation = new Education();
                        newEducation.Staff_ID = editedEducation.StaffID;
                        newEducation.Degree_ID = editedEducation.DegreeID;
                        newEducation.School = editedEducation.School;
                        newEducation.Completed_Date = editedEducation.CompletedDate;
                        newEducation.Created_By = currentUserName;
                        newEducation.Created_On = currentTime;
                        newEducation.Modified_By = currentUserName;
                        newEducation.Modified_On = currentTime;

                        db.Educations.Add(newEducation);
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
                return RedirectToAction("Index", "Staff");
            }

        // GET: Educations
        public ActionResult Index()
        {
            var educations = db.Educations.Include(e => e.Adm_Degree).Include(e => e.Staff);
            return View(educations.ToList());
        }

        // GET: Educations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = db.Educations.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // GET: Educations/Create
        public ActionResult Create(int? id)
        {
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree");
            ViewBag.DateTime = DateTime.Now;

            if (ModelState.IsValid && id != null)
                ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", id);
            else
                ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name");

            return View();
        }

        // POST: Educations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Staff_ID,School,Degree_ID,Completed_Date,Created_On,Created_By,Modified_On,Modified_By")] Education education)
        {
            if (ModelState.IsValid)
            {
                db.Educations.Add(education);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", education.Degree_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", education.Staff_ID);
            return View(education);
        }

        // GET: Educations/Edit/5
        public ActionResult Edit(int? id, int? staff_id)
        {
            if (id == null || staff_id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Education education = db.Educations.SingleOrDefault(x => x.ID == id && x.Staff_ID == staff_id);

            if (education == null)
            {
                return HttpNotFound();
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", education.Degree_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", education.Staff_ID);
            return View(education);
        }

        // POST: Educations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Staff_ID,School,Degree_ID,Completed_Date,Created_On,Created_By,Modified_On,Modified_By")] Education education)
        {
            if (ModelState.IsValid)
            {
                db.Entry(education).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DateTime = DateTime.Now;
            ViewBag.Degree_ID = new SelectList(db.Adm_Degrees, "ID", "Degree", education.Degree_ID);
            ViewBag.Staff_ID = new SelectList(db.Staffs, "ID", "Staff_Name", education.Staff_ID);
            return View(education);
        }

        // GET: Educations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education education = db.Educations.Find(id);
            if (education == null)
            {
                return HttpNotFound();
            }
            return View(education);
        }

        // POST: Educations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Education education = db.Educations.Find(id);
            db.Educations.Remove(education);
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
