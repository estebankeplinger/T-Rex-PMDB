using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Diagnostics;


namespace Portfolio_Management.Controllers
{
    public class RoleController : ApplicationBaseController
    {

        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Role
        public ActionResult Index()
        {

            var Roles = context.Roles.ToList();
            return View(Roles);

        }

        // <summary>
        // Create  a New role
        // </summary>
        // <returns></returns>
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        // <summary>
        // Create a New Role
        // </summary>
        // <param name="Role"></param>
        // <returns></returns>
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // <summary>
        // Returns Users, roles
        // </summary>
        // <param name="Role"></param>
        // <returns>
        // Populated list of users, roles
        // </returns>
        public ActionResult Dashboard(string searchString)
        {

            var context = new ApplicationDbContext();
            var userRoleViewModel = new UsersRolesViewModel();

            var userList = getUsers();

            if (!string.IsNullOrEmpty(searchString))
            {
                Debug.WriteLine("Search string found" + searchString);
                foreach (var user in getUsers())
                {
                    //if user doesn't match search string, remove them from user list to show
                    if (!user.FirstName.Contains(searchString) || !user.LastName.Contains(searchString) || !user.UserName.Contains(searchString))
                        userList.Remove(user);
                }
            }

            userRoleViewModel.users = userList;
            userRoleViewModel.roles = getRoles();

            //return populated view model object
            return View(userRoleViewModel);

        }

        public ActionResult ChangeUserRole(string username)
        {
            var users = context.Users.ToList();
            Debug.WriteLine("---------------------------              Selected user name is:"+ username);
            
            var userRoles = users.Find(item => item.UserName == username);

            //Debug.WriteLine("Got to chengeuserrole method, user name from selected value is {0}", userRoles.FirstName);

            ChangeRoleViewModel crVM = new ChangeRoleViewModel();
            crVM.id = userRoles.Id;
            crVM.username = username;
            crVM.firstName = userRoles.FirstName;
            crVM.lastName = userRoles.LastName;
            crVM.roles = getRoles();
            crVM.currentUserRole = userRoles.userRole;

            Debug.WriteLine("Selected user id, name, role is: "+crVM.id + username + crVM.firstName + crVM.lastName + crVM.currentUserRole);

            return PartialView("_AssignRolePartial",crVM);
        }

        //Return role list as IdentityRole list
        public List<IdentityRole> getRoles()
        {
            List<IdentityRole> roleList = new List<IdentityRole>();
            var contextRoles = context.Roles.ToList();
            //get all roles, assign to user list view model
            foreach (var j in contextRoles)
            {
                IdentityRole role = new IdentityRole();

                role.Name = j.Name;

                roleList.Add(role);

            }
            return roleList;
        }

        //Return user list as RegisterViewModel list
        public List<RegisterViewModel> getUsers()
        {
            List<RegisterViewModel> usersList = new List<RegisterViewModel>();
            var contextUsers = context.Users.ToList();
            //get all users, assign to user list view model
            foreach (var i in contextUsers)
            {

                RegisterViewModel usersRVM = new RegisterViewModel();

                usersRVM.FirstName = i.FirstName;
                usersRVM.LastName = i.LastName;
                usersRVM.UserRole = i.userRole;
                usersRVM.UserName = i.UserName;

                usersList.Add(usersRVM);

            }
            return usersList;
        }

        //[HttpPost]
        //public ActionResult Dashboard(UsersRolesViewModel urVM)
        //{
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        //    //UserManager.AddToRoleAsync(urVM.userId, role);
        //    //context.SaveChanges();
        //    Debug.WriteLine("---------------------------              posted back");
        //    Debug.WriteLine("urVM details: {0}", urVM.selectedRole);
        //    //Debug.WriteLine("Selected user is: {0}, selected role is: {1}",urVM.u)
        //    return RedirectToAction("Dashboard");
        //} 


        //public ActionResult AssignRole()
        //{
        //    var context = new ApplicationDbContext();
        //    IEnumerable<AssignUserToRoleViewModel> userRoles;

        //}

        //public ActionResult AssignRole(RoleViewModels model)
        //{
        //    var context = new ApplicationDbContext();
        //    List<RoleViewModels> userList = new List<RoleViewModels>();
        //    var roles = context.Roles.ToList();
        //    var users = context.Users.ToList();

        //    foreach(var i in roles)
        //    {
        //        foreach(var j in users)
        //        {

        //        }
        //    }
        //}

        //[HttpPost]
        //public ActionResult AssignRole(AssignUserToRoleViewModel model)
        //{
        //    var context = new ApplicationDbContext();
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        //    UserManager.AddToRole(model.userID, model.role);
        //    model.username = User.Identity.Name;
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}


    }
}