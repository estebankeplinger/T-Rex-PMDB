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
    
    public partial class Adm_Clearance_Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adm_Clearance_Status()
        {
            this.Security_Workflow = new HashSet<Security_Workflow>();
        }
    
        public short ID { get; set; }
        public string Clearance_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Security_Workflow> Security_Workflow { get; set; }
    }
}
