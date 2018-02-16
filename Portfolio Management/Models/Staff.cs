//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portfolio_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Certifications = new HashSet<Certification>();
            this.Contracts = new HashSet<Contract>();
            this.Educations = new HashSet<Education>();
            this.Staff_Asset = new HashSet<Staff_Asset>();
            this.Staff_Position = new HashSet<Staff_Position>();
            this.Staff_Skill = new HashSet<Staff_Skill>();
            this.Staff_Training = new HashSet<Staff_Training>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Person_Key { get; set; }
        public int Company_ID { get; set; }
        public string Staff_Name { get; set; }
        public string Prefix { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Middle_Initial { get; set; }
        public string Suffix { get; set; }
        public string Alias { get; set; }
        public string Location { get; set; }
        public string Cell_Phone { get; set; }
        public string Personal_Cell_Phone { get; set; }
        public string Desk_Phone { get; set; }
        public string Company_Email { get; set; }
        public Nullable<bool> IsForeign_National { get; set; }
        public Nullable<bool> IsBillable { get; set; }
        public short Years_of_Experience { get; set; }
        public Nullable<System.DateTime> Hire_Date { get; set; }
        public Nullable<System.DateTime> Exit_Date { get; set; }
        public string Exit_Note { get; set; }
        public Nullable<short> Exit_Reason_ID { get; set; }
        public Nullable<bool> Is_Eligible_for_Rehire { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        public virtual Adm_Exit_Reason Adm_Exit_Reason { get; set; }
        public virtual Adm_Prefix Adm_Prefix { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certification> Certifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Education> Educations { get; set; }
        public virtual Ref_Company Ref_Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Asset> Staff_Asset { get; set; }
        public virtual Staff_Clearance Staff_Clearance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Position> Staff_Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Skill> Staff_Skill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Training> Staff_Training { get; set; }
        public virtual Adm_Suffix Adm_Suffix { get; set; }
    }
}