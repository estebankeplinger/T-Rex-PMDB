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
    
    public partial class Security_Workflow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Security_Workflow()
        {
            this.Staff_Clearance_Workflow = new HashSet<Staff_Clearance_Workflow>();
        }
    
        public int ID { get; set; }
        public int Contract_ID { get; set; }
        public short Display_Order { get; set; }
        public string Workflow { get; set; }
        public bool Always_Display { get; set; }
        public short Clearance_Status_ID { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        public virtual Adm_Clearance_Status Adm_Clearance_Status { get; set; }
        public virtual Contract Contract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff_Clearance_Workflow> Staff_Clearance_Workflow { get; set; }
    }
}