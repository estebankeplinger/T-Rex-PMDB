using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio_Management.Models
{

public class newStaffViewModel
    {
        public newStaffViewModel()
        {
            var db = new PMDataEntities();
            numNewStaff = db.Staffs.Count();
            lblNumNewStaff = "Number of Staff in the PMDB";
        }
        public int numNewStaff { get; set; }
        public string lblNumNewStaff { get; set; }
    }
}