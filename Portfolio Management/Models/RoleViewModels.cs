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
            Roles = new List<AspNetRole>();

        }

        [Display(Name = "User List")]
        public List<UserAccountsViewModel> Users { get; set; }

        [Display(Name = "Role List")]
        public List<AspNetRole> Roles { get; set; }

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

        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Assigned Roles")]
        public List<string> Roles { get; set; }
        [Display(Name = "Username")]
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