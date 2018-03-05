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
            Users = new List<UserAccountsViewModel>();
            Roles = new List<IdentityRole>();

        }

        [Display(Name = "User List")]
        public List<UserAccountsViewModel> Users { get; set; }

        [Display(Name = "Role List")]
        public List<IdentityRole> Roles { get; set; }

    }
    public class StaffManagerViewModel
    {
        public string StaffName { get; set; }
        public string test { get; set; }
    }

    public class UserAccountsViewModel
    {
        public UserAccountsViewModel()
        {
            Roles = new List<string>();
        }
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Roles { get; set; }

        public string UserName { get; set; }
    }

    public class RolesViewModel
    {
        public string Username { get; set; }
        public IEnumerable<string> RoleNames { get; set; }
    }

    public class ChangeRoleViewModel
    {
        public ChangeRoleViewModel()
        {
            Roles = new List<SelectListItem>();
        }

        public string CurrentUserRole { get; set; }

        public string Username { get; set; }
        public string ID { get; set; }

        public string NewUserRole { get; set; }

        public List<SelectListItem> Roles { get; set; }
    }
    public class DeleteUserRoleViewModel
    {
        public string ID { get; set; }
        public string roleToDelete { get; set; }
    }

    public class ContactListViewModel
    {
        public List<Staff> Staffs { get; set; }
    }

}