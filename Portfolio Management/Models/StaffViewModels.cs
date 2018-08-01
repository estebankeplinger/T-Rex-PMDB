using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Portfolio_Management.Models
{

    public class StaffDashboardViewModel
    {
        public StaffDashboardViewModel()
        {
            PMDataEntities db = new PMDataEntities();
            SelectedStaffData = new SelectedStaffDataViewModel();
            AllStaffData = new AllStaffViewModel();
            AllSkillsData = new AllSkillsViewModel();
            AllEducationsData = new AllEducationsViewModel();
            ManageSkillDataList = new List<ManageSkillViewModel>();
            ManageEducationsDataList = new List<ManageStaffEducationsViewModel>();

            var staffs = db.Staffs.Include(s => s.Adm_Exit_Reason).Include(s => s.Adm_Prefix).Include(s => s.Adm_Suffix).Include(s => s.Ref_Company).Include(s => s.Staff_Clearance);
            AllStaffData.Staff = staffs.ToList();
        }
        public int NumStaff { get; set; }
        public int ActiveStaff { get; set; }

        public List<CompanyData> CompanyChart { get; set; }

        public SelectedStaffDataViewModel SelectedStaffData { get; set; }
        public AllStaffViewModel AllStaffData { get; set; }
        public AllSkillsViewModel AllSkillsData { get; set; }
        public AllEducationsViewModel AllEducationsData { get; set; }

        //List of all skills, along with whether or not the user has the skill
        public List<ManageSkillViewModel> ManageSkillDataList { get; set; }
        public List<ManageStaffEducationsViewModel> ManageEducationsDataList { get; set; }
        public class CompanyData
        {
            public int CompanyID { get; set; }
            public string CompanyName { get; set; }
            public string CompanyColor { get; set; }
            public int ShareOfWorkforce { get; set; }
        }
    }
    public class ManageSkillViewModel
    {
        public int StaffID { get; set; }
        public int SkillID { get; set; }
        public short ProficiencyID { get; set; }
        public string SkillName { get; set; }
        public string ProficiencyName { get; set; }

        [Display(Name="Has Skill?")]
        public bool HasSkill { get; set; }

        [Display(Name ="Remove Skill?")]
        public bool RemoveSKill { get; set; }

        public string StaffSkillRadioButtonID { get; set; }
        
    }

    public class ManageStaffEducationsViewModel
    {
        public int EducationID { get; set; }
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string School { get; set; }
        public short DegreeID { get; set; }
        public DateTime CompletedDate { get; set; }
        [Display(Name ="Remove Education?")]
        public bool RemoveEducation { get; set; }
        public bool HasEducation { get; set; }
        public int CurrentListIndex { get; set; }
        public bool IsNewSkill { get; set; }
    }
    

    public class AllStaffViewModel
    {
        public List<Staff> Staff { get; set; }
    }
    public class AllEducationsViewModel
    {
        public AllEducationsViewModel()
        {
            Educations = new List<Education>();
            Degrees = new List<Adm_Degree>();

            PMDataEntities db = new PMDataEntities();

            Degrees = db.Adm_Degrees.ToList();
            Educations = db.Educations.ToList();
        }
        public List<Education> Educations{ get; set; }
        public List<Adm_Degree> Degrees { get; set; }
    }

    public class AllSkillsViewModel
    {
        public AllSkillsViewModel()
        {
            Skills = new List<Ref_Skill>();
            Proficiencies = new List<Adm_Proficiency>();
        }
        public List<Ref_Skill> Skills { get; set; }
        public List<Adm_Proficiency> Proficiencies { get; set; }
    }

    public class SelectedStaffDataViewModel
    {
        public SelectedStaffDataViewModel()
        {
            StaffEducations = new List<Education>();
            StaffCertifications = new List<Certification>();
            StaffSkills = new List<Staff_Skill>();
            StaffPositions = new List<Staff_Position>();
            StaffAssets = new List<Staff_Asset>();
            StaffTrainings = new List<Staff_Training>();
            StaffClearances = new List<Staff_Clearance>();
            StaffContracts = new List<Contract>();
        }
        public Staff Staff { get; set; }
        public List<Education> StaffEducations { get; set; }
        public List<Certification> StaffCertifications { get; set; }
        public List<Staff_Skill> StaffSkills { get; set; }
        public List<Staff_Position> StaffPositions { get; set; }
        public List<Staff_Asset> StaffAssets { get; set; }
        public List<Staff_Training> StaffTrainings { get; set; }
        public List<Staff_Clearance> StaffClearances { get; set; }
        public List<Contract> StaffContracts { get; set; }
    }

    public class StaffActionsViewModel
    {
        public StaffActionsViewModel()
        {
            StaffEducationAction = new StaffEducationActionViewModel();
        }

        public Boolean IsStaffSelected { get; set; }
        public Staff StaffSelected { get; set; }
        public StaffEducationActionViewModel StaffEducationAction { get; set; }
    }

    public class StaffEducationActionViewModel
    {
        public StaffEducationActionViewModel()
        {
            currentStaffEducation = new List<Education>();
        }

        public List<Education> currentStaffEducation { get; set; }
        public Boolean ShouldRender { get; set; }
        public int SelectedStaffID { get; set; }
    }
}