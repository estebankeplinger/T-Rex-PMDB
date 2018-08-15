using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Management.Models
{   
    public class AdmAgencyMetaData
    {
        [Display(Name = "Agency ID")]
        public short ID { get; set; }
        [Display(Name = "Agency")]
        public string Agency { get; set; }
    }
    public class AdmAssetTypeMetaData
    {
        [Display(Name = "Asset Type ID")]
        public short ID { get; set; }
        [Display(Name = "Asset Type")]
        public string Asset_Type { get; set; }
    }
    public class AdmClearanceMetaData
    {
        [Display(Name = "Clearance Status ID")]
        public short ID { get; set; }
        [Display(Name = "Clearance Status")]
        public string Clearance_Status { get; set; }
    }
    public class AdmContractVehicleMetaData
    {
        [Display(Name = "Contract Vehicle ID")]
        public short ID { get; set; }
        [Display(Name = "Contract Vehicle")]
        public string Vehicle_Name { get; set; }
    }
    public class AdmDegreeMetaData
    {
        [Display(Name ="Degree ID")]
        public short ID { get; set; }
        [Display(Name = "Degree")]
        public string Degree { get; set; }
        [Display(Name = "Offset")]
        public Nullable<int> Offset { get; set; }
    }
    public class AdmExitReasonMetaData
    {
        [Display(Name = "Exit Reason ID")]
        public short ID { get; set; }
        [Display(Name = "Exit Reason")]
        public string Exit_Reason { get; set; }
    }
    public class AdmInfoRiskMetaData
    {
        [Display(Name = "Info Risk ID")]
        public short ID { get; set; }
        [Display(Name = "Info Risk")]
        public string Info_Risk { get; set; }
    }
    public class AdmProficiencyMetaData
    {
        [Display(Name = "Proficiency ID")]
        public short Proficiency_ID { get; set; }
        [Display(Name = "Proficiency")]
        public string Proficiency { get; set; }
    }
    public class AdmRequisitionStatusMetaData
    {
        [Display(Name = "Requisition Status ID")]
        public short ID { get; set; }
        [Display(Name = "Requisition Status")]
        public string Status { get; set; }
    }
    public class AdmResumeStatusMetaData
    {
        [Display(Name = "Resume Status ID")]
        public short ID { get; set; }
        [Display(Name = "Resume Status")]
        public string Status { get; set; }
    }
    public class AdmSecurityClearanceMetaData
    {
        [Display(Name = "Security Clearance ID")]
        public short ID { get; set; }
        [Display(Name = "Security Clearance")]
        public string Security_Clearance { get; set; }
        [Display(Name = "Security Clearance Abbreviation")]
        public string Security_Clearance_Abbreviation { get; set; }
    }
    public class CertificationMetaData
    {
        [Display(Name = "Certification ID")]
        public int ID { get; set; }
        [Display(Name = "Staff")]
        public int Staff_ID { get; set; }
        [Display(Name = "Certification 1")]
        public string Certification1 { get; set; }
        [Display(Name = "Issuing Agency")]
        public string Issuing_Agency { get; set; }
        [Display(Name = "Certification ID")]
        public string Certification_ID { get; set; }
        [Display(Name = "Date Issued")]
        public System.DateTime Date_Issued { get; set; }
        [Display(Name = "Expiration Date")]
        public Nullable<System.DateTime> Expiration_Date { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
        [Display(Name = "Staff")]
        public virtual Staff Staff { get; set; }
    }
    public class ContractPositionMetaData
    {
        [Display(Name = "Contract Position")]
        public int ID { get; set; }
        [Display(Name = "Contract")]
        public int Contract_ID { get; set; }
        [Display(Name = "Role")]
        public int Role_ID { get; set; }
        [Display(Name = "Contract WBS")]
        public string Contract_WBS_ID { get; set; }
        [Display(Name = "Position #")]
        public short Position__ { get; set; }
        [Display(Name = "Info Risk")]
        public short Info_Risk_ID { get; set; }
        [Display(Name = "LCAT")]
        public int LCAT_ID { get; set; }
        [Display(Name = "Date Needed")]
        public Nullable<System.DateTime> DateNeeded { get; set; }
        [Display(Name = "Requisition Status")]
        public short Requisition_Status_ID { get; set; }
        [Display(Name = "Required Security Clearance")]
        public Nullable<short> Required_Security_Clearance_ID { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class ContractWBMetaData
    {
        [Display(Name = "Contract WB ID")]
        public int ID { get; set; }
        [Display(Name = "Contract")]
        public int Contract_ID { get; set; }
        [Display(Name = "Area")]
        public string Area { get; set; }
        [Display(Name = "Level 1")]
        public string Level_1 { get; set; }
        [Display(Name = "Level 2")]
        public string Level_2 { get; set; }
        [Display(Name = "Level 3")]
        public string Level_3 { get; set; }
        [Display(Name = "Level 4")]
        public string Level_4 { get; set; }
        [Display(Name = "Level 5")]
        public string Level_5 { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class ContractMetaData
    {
        [Display(Name = "Contract ID")]
        public int ID { get; set; }
        [Display(Name = "Customer")]
        public int Customer_ID { get; set; }
        [Display(Name = "POP Start")]
        public System.DateTime POP_Start { get; set; }
        [Display(Name = "POP End")]
        public System.DateTime POP_End { get; set; }
        [Display(Name = "Program Manager")]
        public int Program_Manager_ID { get; set; }
        [Display(Name = "Is Prime?")]
        public bool IsPrime { get; set; }
        [Display(Name = "Fill By Duration")]
        public Nullable<short> FillByDuration { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class EducationMetaData
    {
        [Display(Name = "Education ID")]
        public int ID { get; set; }
        [Display(Name = "Staff")]
        public int Staff_ID { get; set; }
        [Display(Name = "School/University")]
        public string School { get; set; }
        [Display(Name = "Degree")]
        public short Degree_ID { get; set; }
        [Display(Name = "Completed Date")]
        public System.DateTime Completed_Date { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Createdd By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
        [Display(Name = "Admin Degree")]
        public virtual Adm_Degree Adm_Degree { get; set; }
        [Display(Name = "Staff")]
        public virtual Staff Staff { get; set; }
    }
    public class PositionForecastMetaData
    {
        [Display(Name = "Position Forecast ID")]
        public int ID { get; set; }
        [Display(Name = "Contract Position")]
        public Nullable<int> Contract_Position_ID { get; set; }
        [Display(Name = "Pay Period")]
        public Nullable<int> Pay_Period_ID { get; set; }
        [Display(Name = "FTE")]
        public Nullable<decimal> FTE { get; set; }
        [Display(Name = "Hours")]
        public Nullable<decimal> Hours { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class RefAssetMetaData
    {
        [Display(Name = "Asset ID")]
        public int ID { get; set; }
        [Display(Name = "Asset Name")]
        public string Asset_Name { get; set; }
        [Display(Name = "Asset Type")]
        public short Asset_Type_ID { get; set; }
    }
    public class RefCompanyMetaData
    {
        [Display(Name = "Company ID")]
        public int ID { get; set; }
        [Display(Name = "Company")]
        public string Company { get; set; }
    }
    public class RefContractLCATMetaData
    {
        [Display(Name = "Contract LCAT ID")]
        public int ID { get; set; }
        [Display(Name = "Contract")]
        public Nullable<int> Contract_ID { get; set; }
        [Display(Name = "Vehicle LCAT")]
        public Nullable<int> Vehicle_LCAT_ID { get; set; }
        [Display(Name = "ESF LCAT")]
        public string ESF_LCAT { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Years of Experience with Degree")]
        public Nullable<short> Years_of_Experience_with_Degree { get; set; }
    }
    public class RefContractVehicleLCATMetaData
    {
        [Display(Name = "Contract Vehicle LCAT ID")]
        public int ID { get; set; }
        [Display(Name = "Contract Vehicle")]
        public short Contract_Vehicle_ID { get; set; }
        [Display(Name = "LCAT")]
        public string LCAT { get; set; }
        [Display(Name = "LCAT Description")]
        public string LCAT_Description { get; set; }
        [Display(Name = "Years of Experience with Degree")]
        public short Years_of_Experience_with_Degree { get; set; }
        [Display(Name = "Degree ID")]
        public short Degree_ID { get; set; }
    }
    public class RefCustomerMetaData
    {
        [Display(Name = "Customer ID")]
        public int ID { get; set; }
        [Display(Name = "Cutomer")]
        public string Customer { get; set; }
        [Display(Name = "Agency")]
        public Nullable<short> Agency_ID { get; set; }
    }
    public class RefPayPeriodMetaData
    {
        [Display(Name = "Pay Period ID")]
        public int ID { get; set; }
        [Display(Name = "Period #")]
        public Nullable<short> Period__ { get; set; }
        public Nullable<short> Year { get; set; }
        public Nullable<short> Month { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
    }
    public class RefRoleMetaData
    {
        [Display(Name = "Role ID")]
        public int ID { get; set; }
        public string Role { get; set; }
    }
    public class RefSkillMetaData
    {
        [Display(Name ="Skill ID")]
        public int ID { get; set; }
        public string Skill { get; set; }
    }
    public class RefTeleworkAgreementMetaData
    {
        [Display(Name = "Telework Agreement ID")]
        public int ID { get; set; }
        [Display(Name = "Telework Agreement")]
        public string Telework_Agreement { get; set; }
    }
    public class RefTrainingMetaData
    {
        [Display(Name = "Training ID")]
        public int ID { get; set; }
        [Display(Name = "Contract")]
        public Nullable<int> Contract_ID { get; set; }
        [Display(Name = "Training")]
        public string Training { get; set; }
        [Display(Name = "Date Due")]
        public System.DateTime Date_Due { get; set; }
        [Display(Name = "Instructions")]
        public string Instructions { get; set; }
    }
    public class SecurityWorkflowMetaData
    {
        [Display(Name = "Security Workflow ID")]
        public int ID { get; set; }
        [Display(Name = "Contract")]
        public int Contract_ID { get; set; }
        [Display(Name = "Display Order")]
        public short Display_Order { get; set; }
        [Display(Name = "Workflow")]
        public string Workflow { get; set; }
        [Display(Name = "Always Display")]
        public bool Always_Display { get; set; }
        [Display(Name = "Clearance Status")]
        public short Clearance_Status_ID { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modifed By")]
        public string Modified_By { get; set; }
    }
    public class StaffMetadata
    {
        [Display(Name = "Staff ID")]
        public int ID;
        [Display(Name = "Person Key")]
        public Nullable<int> Person_Key;
        [Display(Name = "Company")]
        public int Company_ID;
        [Display(Name = "Staff Name")]
        public string Staff_Name;
        [Display(Name = "Prefix")]
        public string Prefix;
        [Display(Name = "Last Name")]
        public string Last_Name;
        [Display(Name = "First Name")]
        public string First_Name;
        [Display(Name = "Middle Initial")]
        public string Middle_Initial;
        [Display(Name = "Suffix")]
        public string Suffix;
        [Display(Name = "Alias")]
        public string Alias;
        [Display(Name = "Location")]
        public string Location;
        [Display(Name = "Cell Phone")]
        public string Cell_Phone;
        [Display(Name = "Personal Cell Phone")]
        public string Personal_Cell_Phone;
        [Display(Name = "Desk Phone")]
        public string Desk_Phone;
        [Display(Name = "Company Email")]
        public string Company_Email;
        [Display(Name = "Foreign National?")]
        public Nullable<bool> IsForeign_National;
        [Display(Name = "Billable?")]
        public Nullable<bool> IsBillable;
        [Display(Name = "Years of Experience")]
        public short Years_of_Experience;
        [Display(Name = "Hire Date")]
        public Nullable<System.DateTime> Hire_Date;
        [Display(Name = "Exit Date")]
        public Nullable<System.DateTime> Exit_Date;
        [Display(Name = "Exit Note")]
        public string Exit_Note;
        [Display(Name = "Exit Reason")]
        public Nullable<short> Exit_Reason_ID;
        [Display(Name = "Eligible for Rehire?")]
        public Nullable<bool> Is_Eligible_for_Rehire;
        [Display(Name = "Created on")]
        public Nullable<System.DateTime> Created_On;
        [Display(Name = "Created by")]
        public string Created_By;
        [Display(Name = "Modified on")]
        public Nullable<System.DateTime> Modified_On;
        [Display(Name = "Modified by")]
        public string Modified_By;
    }
    public class StaffAssetMetaData
    {
        [Display(Name = "Staff Asset ID")]
        public int ID { get; set; }
        [Display(Name = "Staff")]
        public int Staff_ID { get; set; }
        [Display(Name = "Contract")]
        public Nullable<int> Contract_ID { get; set; }
        [Display(Name = "Asset")]
        public int Asset_ID { get; set; }
        [Display(Name = "Item Number")]
        public string Item_Number { get; set; }
        [Display(Name = "Date Issued")]
        public Nullable<System.DateTime> Date_Issued { get; set; }
        [Display(Name = "Date Returned")]
        public Nullable<System.DateTime> Date_Returrned { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modifed By")]
        public string Modified_By { get; set; }
    }
    public class StaffClearanceMetaData
    {
        [Display(Name = "Staff Clearance ID")]
        public int ID { get; set; }
        [Display(Name = "Staff")]
        public Nullable<int> Staff_ID { get; set; }
        [Display(Name = "Staff Clearance")]
        public Nullable<short> Security_Clearance_ID { get; set; }
        [Display(Name = "Date Authorized")]
        public Nullable<System.DateTime> Date_Authorized { get; set; }
        [Display(Name = "Contract")]
        public Nullable<int> Contract_ID { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class StaffClearanceWorkflowMetaData
    {
        [Display(Name = "Staff Clearance Workflow ID")]
        public int ID { get; set; }
        [Display(Name = "Staff Clearance")]
        public int Staff_Clearance_ID { get; set; }
        [Display(Name = "Security Workflow")]
        public int Security_Workflow_ID { get; set; }
        [Display(Name = "Is Active?")]
        public bool Is_Active { get; set; }
        [Display(Name = "Entry Date")]
        public System.DateTime Entry_Date { get; set; }
        [Display(Name = "Exit Date")]
        public System.DateTime Exit_Date { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class StaffPositionMetaData
    {
        [Display(Name = "Staff ID")]
        public int Staff_ID { get; set; }
        [Display(Name = "Contract Position")]
        public int Contract_Position_ID { get; set; }
        [Display(Name = "Is Active?")]
        public Nullable<bool> IsActive { get; set; }
        [Display(Name = "Planned Start Date")]
        public Nullable<System.DateTime> Planned_Start_Date { get; set; }
        [Display(Name = "Active Start Date")]
        public Nullable<System.DateTime> Active_Start_Date { get; set; }
        [Display(Name = "Active End Date")]
        public Nullable<System.DateTime> Active_End_Date { get; set; }
        [Display(Name = "Telework Agreement")]
        public Nullable<int> Telework_Agreement_ID { get; set; }
        [Display(Name = "Resume Status")]
        public Nullable<short> Resume_Status_ID { get; set; }
        [Display(Name = "Is Resume Compliant?")]
        public Nullable<bool> Is_Resume_Compliant { get; set; }
        [Display(Name = "Is LCAT Compliant?")]
        public Nullable<bool> Is_LCAT_Compliant { get; set; }
        [Display(Name = "Compliance Notes")]
        public string Compliance_Notes { get; set; }
        [Display(Name = "Email Address")]
        public string Email_Address { get; set; }
        [Display(Name = "Desk Phone")]
        public string Desk_Phone { get; set; }
        [Display(Name = "Cell Phone")]
        public string Cell_Phone { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class StaffSkillMetaData
    {
        [Display(Name = "Staff ID")]
        public int Staff_ID { get; set; }
        [Display(Name = "Skill")]
        public int Skill_ID { get; set; }
        [Display(Name = "Proficiency")]
        public short Proficiency_ID { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class StaffTrainingMetaData
    {
        [Display(Name = "Staff Training ID")]
        public int ID { get; set; }
        [Display(Name = "Staff")]
        public int Staff_ID { get; set; }
        [Display(Name = "Training")]
        public int Training_ID { get; set; }
        [Display(Name = "Date Completed")]
        public Nullable<System.DateTime> Date_Completed { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }
    public class WorkshareMetaData
    {
        [Display(Name = "Workshare ID")]
        public int ID { get; set; }
        [Display(Name = "Contract Position")]
        public Nullable<int> Contract_Position_ID { get; set; }
        [Display(Name = "Company")]
        public Nullable<int> Company_ID { get; set; }
        [Display(Name = "Date Released")]
        public Nullable<System.DateTime> Date_Released { get; set; }
        [Display(Name = "Is Primary?")]
        public Nullable<bool> IsPrimary { get; set; }
        [Display(Name = "Created On")]
        public System.DateTime Created_On { get; set; }
        [Display(Name = "Created By")]
        public string Created_By { get; set; }
        [Display(Name = "Modified On")]
        public System.DateTime Modified_On { get; set; }
        [Display(Name = "Modified By")]
        public string Modified_By { get; set; }
    }

}

