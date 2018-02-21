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

    [MetadataType(typeof(EducationMetaData))]
    public partial class Education { }

    [MetadataType(typeof(RefCompanyMetaData))]
    public partial class Ref_Company { }

    public class DataEntityExtensions
    {
       
    }



}


