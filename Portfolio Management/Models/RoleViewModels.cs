using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace Portfolio_Management.Models
{

    public class UsersRolesViewModel
    {
        public UsersRolesViewModel()
        {
            users = new List<RegisterViewModel>();
            roles = new List<IdentityRole>();
        }

        [Display(Name = "User List")]
        public List<RegisterViewModel> users { get; set; }

        [Display(Name = "Role List")]
        public List<IdentityRole> roles { get; set; }

        public string selectedUsername { get; set; }
    }

    public class ChangeRoleViewModel
    {
        public ChangeRoleViewModel()
        {
            roles = new List<IdentityRole>();
        }

        public string currentUserRole { get; set; }

        public string username { get; set; }
        public string id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string newUserRole { get; set; }

        public List<IdentityRole> roles { get; set; }
 
    }

}