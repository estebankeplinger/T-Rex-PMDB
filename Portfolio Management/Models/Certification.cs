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
    
    public partial class Certification
    {
        public int ID { get; set; }
        public int Staff_ID { get; set; }
        public string Certification1 { get; set; }
        public string Issuing_Agency { get; set; }
        public string Certification_ID { get; set; }
        public System.DateTime Date_Issued { get; set; }
        public Nullable<System.DateTime> Expiration_Date { get; set; }
        public System.DateTime Created_On { get; set; }
        public string Created_By { get; set; }
        public System.DateTime Modified_On { get; set; }
        public string Modified_By { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}