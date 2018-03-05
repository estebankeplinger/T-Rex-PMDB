using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Management.Models
{
    //In Metadata.cs
    //Define model attributes

    [MetadataType(typeof(AdmAgencyMetaData))]
    public partial class Adm_Agency { }

    [MetadataType(typeof(AdmAssetTypeMetaData))]
    public partial class Adm_Asset_Type { }

    [MetadataType(typeof(AdmClearanceMetaData))]
    public partial class Adm_Clearance_Status { }

    [MetadataType(typeof(AdmContractVehicleMetaData))]
    public partial class Adm_Contract_Vehicle { }

    [MetadataType(typeof(AdmDegreeMetaData))]
    public partial class Adm_Degreee { }

    [MetadataType(typeof(AdmExitReasonMetaData))]
    public partial class Adm_Exit_Reason { }

    [MetadataType(typeof(AdmInfoRiskMetaData))]
    public partial class Adm_Info_Risk { }
    
    [MetadataType(typeof(AdmProficiencyMetaData))]
    public partial class Adm_Proficiency { }

    [MetadataType(typeof(AdmRequisitionStatusMetaData))]
    public partial class Adm_Requisition_Status { }

    [MetadataType(typeof(AdmResumeStatusMetaData))]
    public partial class Adm_Resume_Status { }

    [MetadataType(typeof(AdmSecurityClearanceMetaData))]
    public partial class Adm_Security_Clearance { }

    [MetadataType(typeof(CertificationMetaData))]
    public partial class Certification { }

    //May need to be Contract
    [MetadataType(typeof(ContractMetaData))]
    public partial class Contract { }

    [MetadataType(typeof(ContractPositionMetaData))]
    public partial class Contract_Position { }

    [MetadataType(typeof(ContractWBMetaData))]
    public partial class Contract_WB { }

    [MetadataType(typeof(EducationMetaData))]
    public partial class Education { }

    [MetadataType(typeof(PositionForecastMetaData))]
    public partial class Position_Forecast { }

    [MetadataType(typeof(RefAssetMetaData))]
    public partial class Ref_Asset { }

    [MetadataType(typeof(RefCompanyMetaData))]
    public partial class Ref_Company { }

    [MetadataType(typeof(RefContractLCATMetaData))]
    public partial class Ref_Contract_LCAT { }

    [MetadataType(typeof(RefContractVehicleLCATMetaData))]
    public partial class Ref_Contract_Vehicle_LCAT { }

    [MetadataType(typeof(RefCustomerMetaData))]
    public partial class Ref_Customer { }

    [MetadataType(typeof(RefPayPeriodMetaData))]
    public partial class Ref_Pay_Period { }

    [MetadataType(typeof(RefRoleMetaData))]
    public partial class Ref_Role { }

    [MetadataType(typeof(RefSkillMetaData))]
    public partial class Ref_Skill { }

    [MetadataType(typeof(RefTeleworkAgreementMetaData))]
    public partial class Ref_Telework_Agreement { }

    [MetadataType(typeof(RefTrainingMetaData))]
    public partial class Ref_Training { }

    [MetadataType(typeof(SecurityWorkflowMetaData))]
    public partial class Security_Workflow { }

    [MetadataType(typeof(StaffMetadata))]
    public partial class Staff { }

    [MetadataType(typeof(StaffAssetMetaData))]
    public partial class Staff_Asset { }

    [MetadataType(typeof(StaffClearanceMetaData))]
    public partial class Staff_Clearance { }

    [MetadataType(typeof(StaffClearanceWorkflowMetaData))]
    public partial class Staff_Clearance_Workflow { }

    [MetadataType(typeof(StaffPositionMetaData))]
    public partial class Staff_Position { }

    [MetadataType(typeof(StaffSkillMetaData))]
    public partial class Staff_Skill { }

    [MetadataType(typeof(StaffTrainingMetaData))]
    public partial class Staff_Training { }

    [MetadataType(typeof(WorkshareMetaData))]
    public partial class Workshare { }

    public class DataEntityExtensions
    {
       
    }



}


