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
    
    public partial class Staff_Skill
    {
        public int Staff_ID { get; set; }
        public int Skill_ID { get; set; }
        public short Proficiency_ID { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        public virtual Adm_Proficiency Adm_Proficiency { get; set; }
        public virtual Ref_Skill Ref_Skill { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
