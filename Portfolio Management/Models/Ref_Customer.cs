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
    
    public partial class Ref_Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ref_Customer()
        {
            this.Contracts = new HashSet<Contract>();
        }
    
        public int ID { get; set; }
        public string Customer { get; set; }
        public Nullable<short> Agency_ID { get; set; }
    
        public virtual Adm_Agency Adm_Agency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
