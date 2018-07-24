﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PMDataEntities : DbContext
    {
        public PMDataEntities()
            : base("name=PMDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Adm_Agency> Adm_Agencies { get; set; }
        public virtual DbSet<Adm_Asset_Type> Adm_Asset_Types { get; set; }
        public virtual DbSet<Adm_Clearance_Status> Adm_Clearance_Status { get; set; }
        public virtual DbSet<Adm_Contract_Vehicle> Adm_Contract_Vehicles { get; set; }
        public virtual DbSet<Adm_Degree> Adm_Degrees { get; set; }
        public virtual DbSet<Adm_Exit_Reason> Adm_Exit_Reasons { get; set; }
        public virtual DbSet<Adm_Info_Risk> Adm_Info_Risks { get; set; }
        public virtual DbSet<Adm_Prefix> Adm_Prefixes { get; set; }
        public virtual DbSet<Adm_Proficiency> Adm_Proficiencies { get; set; }
        public virtual DbSet<Adm_Requisition_Status> Adm_Requisition_Status { get; set; }
        public virtual DbSet<Adm_Resume_Status> Adm_Resume_Status { get; set; }
        public virtual DbSet<Adm_Security_Clearance> Adm_Security_Clearances { get; set; }
        public virtual DbSet<Adm_Suffix> Adm_Suffixes { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Contract_Position> Contract_Positions { get; set; }
        public virtual DbSet<Contract_WB> Contract_WBS { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Position_Forecast> Position_Forecasts { get; set; }
        public virtual DbSet<Ref_Asset> Ref_Assets { get; set; }
        public virtual DbSet<Ref_Company> Ref_Companies { get; set; }
        public virtual DbSet<Ref_Contract_LCAT> Ref_Contract_LCATs { get; set; }
        public virtual DbSet<Ref_Contract_Vehicle_LCAT> Ref_Contract_Vehicle_LCATs { get; set; }
        public virtual DbSet<Ref_Customer> Ref_Customers { get; set; }
        public virtual DbSet<Ref_Pay_Period> Ref_Pay_Periods { get; set; }
        public virtual DbSet<Ref_Role> Ref_Roles { get; set; }
        public virtual DbSet<Ref_Skill> Ref_Skills { get; set; }
        public virtual DbSet<Ref_Telework_Agreement> Ref_Telework_Agreements { get; set; }
        public virtual DbSet<Ref_Training> Ref_Trainings { get; set; }
        public virtual DbSet<Security_Workflow> Security_Workflows { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Staff_Asset> Staff_Assets { get; set; }
        public virtual DbSet<Staff_Clearance_Workflow> Staff_Clearance_Workflows { get; set; }
        public virtual DbSet<Staff_Position> Staff_Positions { get; set; }
        public virtual DbSet<Staff_Skill> Staff_Skills { get; set; }
        public virtual DbSet<Staff_Training> Staff_Trainings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Workshare> Workshares { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<Staff_Clearance> Staff_Clearances { get; set; }
    
        public virtual int sp_MScleanupmergepublisher()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MScleanupmergepublisher");
        }
    
        public virtual int sp_MSrepl_startup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MSrepl_startup");
        }
    
        public virtual int sp_MScleanupmergepublisher1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MScleanupmergepublisher1");
        }
    
        public virtual int sp_MSrepl_startup1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MSrepl_startup1");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
