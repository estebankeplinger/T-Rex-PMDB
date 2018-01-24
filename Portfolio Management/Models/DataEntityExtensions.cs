using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Management.Models
{
    //In Metadata.cs
    //Define model attributes
    [MetadataType(typeof(StaffMetadata))]
    public partial class Staff { }

    public class DataEntityExtensions
    {
       
    }



}


//public int ID { get; set; }
//public Nullable<int> Person_Key { get; set; }
//public int Company_ID { get; set; }
//public string Staff_Name { get; set; }
//public string Prefix { get; set; }
//public string Last_Name { get; set; }
//public string First_Name { get; set; }
//public string Middle_Initial { get; set; }
//public string Suffix { get; set; }
//public string Alias { get; set; }
//public string Location { get; set; }
//public string Cell_Phone { get; set; }
//public string Personal_Cell_Phone { get; set; }
//public string Desk_Phone { get; set; }
//public string Company_Email { get; set; }
//public Nullable<bool> IsForeign_National { get; set; }
//public Nullable<bool> IsBillable { get; set; }
//public short Years_of_Experience { get; set; }
//public Nullable<System.DateTime> Hire_Date { get; set; }
//public Nullable<System.DateTime> Exit_Date { get; set; }
//public string Exit_Note { get; set; }
//public Nullable<short> Exit_Reason_ID { get; set; }
//public Nullable<bool> Is_Eligible_for_Rehire { get; set; }
//public Nullable<System.DateTime> Created_On { get; set; }
//public string Created_By { get; set; }
//public Nullable<System.DateTime> Modified_On { get; set; }
//public string Modified_By { get; set; }