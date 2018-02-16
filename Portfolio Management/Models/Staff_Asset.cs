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
    
    public partial class Staff_Asset
    {
        public int ID { get; set; }
        public int Staff_ID { get; set; }
        public Nullable<int> Contract_ID { get; set; }
        public int Asset_ID_ { get; set; }
        public string Item_Number { get; set; }
        public Nullable<System.DateTime> Date_Issued { get; set; }
        public Nullable<System.DateTime> Date_Returrned { get; set; }
        public string Notes { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual Ref_Asset Ref_Asset { get; set; }
        public virtual Staff Staff { get; set; }
    }
}