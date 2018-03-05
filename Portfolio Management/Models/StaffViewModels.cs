using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Management.Models
{
    
    public class StaffDashboardViewModel
    {
        public int NumStaff { get; set; }
        public int ActiveStaff { get; set; }

        public List<CompanyData> CompanyChart { get; set; }

        public class CompanyData
        {
            public int CompanyID { get; set; }
            public string CompanyName { get; set; }
            public string CompanyColor { get; set; }
            public int ShareOfWorkforce { get; set; }
        }
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
        public Boolean ShouldRender { get ; set; }
        public int SelectedStaffID { get; set; }
    }
}