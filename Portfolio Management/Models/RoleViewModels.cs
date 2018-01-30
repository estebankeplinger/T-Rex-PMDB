using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Portfolio_Management.Models
{
    public class RoleViewModels
    {
        public List<UsersInRoleViewModel> roles;
        public List<AssignUserToRoleViewModel> userRoles;
    }
    public class UsersInRoleViewModel
    {
        [Display(Name ="User ID")]
        public string userID { get; set; }
        [Display(Name ="Username")]
        public string username { get; set; }
        [Display(Name ="Role")]
        public string role { get; set; }
    }

    public class AssignUserToRoleViewModel
    {
        public string userID { get; set; }
        public string username { get; set; }
        public string role { get; set; }
    }

}