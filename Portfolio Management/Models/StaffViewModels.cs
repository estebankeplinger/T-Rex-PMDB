using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio_Management.Models
{

    public class StaffDashboardViewModel
    {
        public StaffDashboardViewModel()
        {
            SelectedStaffData = new SelectedStaffDataViewModel();
            AllStaffData = new AllStaffViewModel();
            AllSkillsData = new AllSkillsViewModel();
            ManageSkillDataList = new List<ManageSkillViewModel>();
        }
        public int NumStaff { get; set; }
        public int ActiveStaff { get; set; }

        public List<CompanyData> CompanyChart { get; set; }

        public SelectedStaffDataViewModel SelectedStaffData { get; set; }
        public AllStaffViewModel AllStaffData { get; set; }
        public AllSkillsViewModel AllSkillsData { get; set; }

        //List of all skills, along with whether or not the user has the skill
        public List<ManageSkillViewModel> ManageSkillDataList { get; set; }
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

    public class AllStaffViewModel
    {
        public List<Staff> Staff { get; set; }
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
            StaffSkills = new List<Staff_Skill>();
            StaffPositions = new List<Staff_Position>();
            StaffSkillsIDs = new List<int>();
        }
        public Staff Staff { get; set; }
        public List<Education> StaffEducations { get; set; }
        public List<Staff_Skill> StaffSkills { get; set; }
        public List<Staff_Position> StaffPositions { get; set; }

        public List<int> StaffSkillsIDs = new List<int>();

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