using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Management.Models
{
    public class StaffMetadata
    {
        //Staff Model

        //Staff.ID
        [Display(Name = "ID")]
        public int ID;

        //Staff.Person_key
        [Display(Name = "Person Key")]
        public Nullable<int> Person_Key;

        //Staff.Company_ID
        [Display(Name = "Company ID")]
        public int Company_ID;

        //Staff.Staff_Name
        [Display(Name = "Staff Name")]
        public string Staff_Name;

        //Staff.Prefix
        [Display(Name = "Prefix")]
        public string Prefix;

        //Staff.Last_Name
        [Display(Name = "Last Name")]
        public string Last_Name;

        //Staff.First_Name
        [Display(Name = "First Name")]
        public string First_Name;

        //Staff.Middle_Initial
        [Display(Name = "Middle Initial")]
        public string Middle_Initial;

        //Staff.Suffix
        [Display(Name = "Suffix")]
        public string Suffix;

        //Staff.Alias
        [Display(Name = "Alias")]
        public string Alias;

        //Staff.Location
        [Display(Name = "Location")]
        public string Location;

        //Staff.Cell_Phone
        [Display(Name = "Cell Phone")]
        public string Cell_Phone;

        //Staff.Personal_Cell_Phone
        [Display(Name = "Personal Cell Phone")]
        public string Personal_Cell_Phone;

        //Staff.Desk_Phone
        [Display(Name = "Desk Phone")]
        public string Desk_Phone;

        //Staff.Company_Email
        [Display(Name = "Company Email")]
        public string Company_Email;

        //Staff.IsForeign_National
        [Display(Name = "Foreign National?")]
        public Nullable<bool> IsForeign_National;

        //Staff.IsBillable
        [Display(Name = "Billable?")]
        public Nullable<bool> IsBillable;

        //Staff.Years_of_Experience
        [Display(Name = "Years of Experience")]
        public short Years_of_Experience;

        //Staff.Hire_Date
        [Display(Name = "Hire Date")]
        public Nullable<System.DateTime> Hire_Date;

        //Staff.Exit_Date
        [Display(Name = "Exit Date")]
        public Nullable<System.DateTime> Exit_Date;

        //Staff.Exit_Note
        [Display(Name = "Exit Note")]
        public string Exit_Note;

        //Staff.Exit_Reason_ID
        [Display(Name = "Exit Reason ID")]
        public Nullable<short> Exit_Reason_ID;

        //Staff.Is_Eligible_for_Rehire
        [Display(Name = "Eligible for Rehire?")]
        public Nullable<bool> Is_Eligible_for_Rehire;

        //Staff.Created_On
        [Display(Name = "Created on")]
        public Nullable<System.DateTime> Created_On;

        //Staff.Created_By
        [Display(Name = "Created by")]
        public string Created_By;

        //Staff.Modified_On
        [Display(Name = "Modified on")]
        public Nullable<System.DateTime> Modified_On;

        //Staff.Modified_By
        [Display(Name = "Modified by")]
        public string Modified_By;
    }

    public class EducationMetaData
    {
        [Display(Name ="ID")]
        public int ID { get; set; }

        [Display(Name = "Staff ID")]
        public int Staff_ID { get; set; }

        [Display(Name = "School/University")]
        public string School { get; set; }

        [Display(Name = "Degree ID")]
        public short Degree_ID { get; set; }

        [Display(Name = "Completed Date")]
        public System.DateTime Completed_Date { get; set; }

        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }

        [Display(Name = "Createdd By")]
        public string Created_By { get; set; }

        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }

        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }

        [Display(Name = "Admin Degree")]
        public virtual Adm_Degree Adm_Degree { get; set; }

        [Display(Name = "Staff")]
        public virtual Staff Staff { get; set; }
    }

    public class RefCompanyMetaData
    {
        [Display(Name ="Company ID")]
        public int ID { get; set; }
        [Display(Name = "Company")]
        public string Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workshare> Workshares { get; set; }
    }
}

