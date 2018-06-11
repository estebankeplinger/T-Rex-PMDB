using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Management.Models
{
    public class StaffSkillViewModel
    {
        public int StaffID { get; set; }
        public int StaffSKillID { get; set; }

    }

    public class EditStaffSkillViewModel
    {
        public int StaffID { get; set; }

        public int StaffSkillID { get; set; }
    }

    public class AddSKillViewModel
    {
        public int SkillID { get; set; }
        public int StaffID { get; set; }



        public Staff staff { get; set; }

        
    }

}