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
    
    public partial class Staff_Clearance_Workflow
    {
        public int ID { get; set; }
        public int Staff_Clearance_ID { get; set; }
        public int Security_Workflow_ID { get; set; }
        public bool Is_Active { get; set; }
        public System.DateTime Entry_Date { get; set; }
        public System.DateTime Exit_Date { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        public virtual Security_Workflow Security_Workflow { get; set; }
        public virtual Staff_Clearance Staff_Clearance { get; set; }
    }
}
