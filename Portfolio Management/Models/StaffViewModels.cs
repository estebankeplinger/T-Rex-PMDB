using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Management.Models
{
    public class StaffViewModels
    {

    }


    public class StaffDashboardViewModel
    {
        public int NumStaff { get; set; }
        public int ActiveStaff { get; set; }

        public List<CompanyData> CompanyChart { get; set; }

        public class CompanyData
        {
            public int CompanyID { get; set; }
            public string CompanyName { get; set; }
            public string companyColor { get; set; }
            public int ShareOfWorkforce { get; set; }

        }
    }

    public class StaffActionsViewModel
    {
        public StaffActionsViewModel()
        {
            AvailableActions = new List<Action>();
            StaffEducationAction = new StaffEducationActionViewModel();
        }
        public Staff StaffSelected { get; set; }

        public List<Action> AvailableActions { get; set; }

        public StaffEducationActionViewModel StaffEducationAction { get; set; }
        public class Action
        {
            public string ActionName { get; set; }
            public int ActionNumber { get; set; }
        }
    }

    public class StaffEducationActionViewModel
    {
        public StaffEducationActionViewModel()
        {
            currentStaffEducation = new List<Education>();
        }
        
        public List<Education> currentStaffEducation { get; set; }

        public Boolean ShouldRender { get ; set; }

        public Boolean IsStaffSelected { get; set; }
        public int SelectedStaffID { get; set; }
    }

    public class StaffCreateEducationViewModel
    {
        public int StaffID { get; set; } 
    }

    
}