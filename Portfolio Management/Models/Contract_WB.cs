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
    
    public partial class Contract_WB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract_WB()
        {
            this.Contract_Position = new HashSet<Contract_Position>();
        }
    
        public int ID { get; set; }
        public int Contract_ID { get; set; }
        public string Area { get; set; }
        public string Level_1 { get; set; }
        public string Level_2 { get; set; }
        public string Level_3 { get; set; }
        public string Level_4 { get; set; }
        public string Level_5 { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_Position> Contract_Position { get; set; }
    }
}
