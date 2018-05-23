using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Diagnostics;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;

namespace Portfolio_Management.Controllers
{
    public class RoleController : ApplicationBaseController
    {

        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Index(string searchString)
        {

            var context = new ApplicationDbContext();
            var userRoleViewModel = new UsersRolesViewModel();

            var userList = getUsers();
            userRoleViewModel.Users = userList;

            if (!string.IsNullOrEmpty(searchString))
            {
                foreach (var user in userList.ToList())
                {
                    //if user doesn't match search string, remove them from user list to show
                    if (!user.FirstName.Contains(searchString) && !user.LastName.Contains(searchString) && !user.UserName.Contains(searchString)
                        && !user.Roles.Contains(searchString))
                    {
                        Debug.WriteLine("--- search string: " + searchString + "Does not relate to anything in this record. Removing...");
                        Debug.WriteLine("--- Removing: " + user.FirstName + ", " + user.LastName);

                        userRoleViewModel.Users.Remove(user);
                    }
                    else
                    {
                        Debug.WriteLine(searchString + " Was contained in: ");
                        Debug.WriteLine("First name: "+user.FirstName.Contains(searchString));
                        Debug.WriteLine("last name: " + user.LastName.Contains(searchString));
                        Debug.WriteLine("Username: " + user.UserName.Contains(searchString));
                        Debug.WriteLine("Role: " + user.Roles.Contains(searchString));
                    }

                }
                Debug.WriteLine("After loop, userList count is " + userList.Count);
            }

            userRoleViewModel.Roles = getRoles();

            return View(userRoleViewModel);
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


        public ActionResult Edit(string Username)
        {
            var users = context.Users.ToList();
            
            var userRoles = users.Find(item => item.UserName == Username);

            //Debug.WriteLine("Got to chengeuserrole method, user name from selected value is {0}", userRoles.FirstName);

            ChangeRoleViewModel crVM = new ChangeRoleViewModel();
            crVM.ID = userRoles.Id;
            crVM.Username = Username;
            crVM.Roles = getRoleSelectList();
            crVM.CurrentUserRole = userRoles.userRole;      

            return View(crVM);
        }

        // POST: Role/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ChangeRoleViewModel crVM)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var result = UserManager.AddToRole(crVM.ID, crVM.NewUserRole);
            if (result.Succeeded)
            {
                Debug.WriteLine("Success changing role");
                return RedirectToAction("Index");
            }
            foreach(var err in result.Errors)
            {
                Debug.WriteLine("error: " + err);
            }
            updateUserRole(crVM);

            return RedirectToAction("Edit");

        }

        // GET: Role/Delete/5
        public async Task<ActionResult> Delete(string username, string roleName)
        {
            DeleteUserRoleViewModel deleteuserVM = new DeleteUserRoleViewModel();

            deleteuserVM.ID = FindUserIDByUsername(username);
            deleteuserVM.roleToDelete = roleName;

            if (deleteuserVM.ID != null && roleName != null)
            {
                await DeleteRolesAsync(deleteuserVM.ID, roleName);
            }

            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        protected string FindUserIDByUsername(string username)
        {
            var userList = context.Users.ToList();
            var user = userList.Find(item => item.UserName == username);

            if(user == null)
            {
                return null;
            }
            else
            {
                return user.Id;
            }
        }

        public async Task DeleteRolesAsync(string id, string roleName)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            IdentityResult deletionResult = await UserManager.RemoveFromRoleAsync(id, roleName);
            
        }

        public void updateUserRole(ChangeRoleViewModel crVm)
        {
            var userList = context.Users.ToList();
            foreach (var i in userList)
            {
                if (i.Id == crVm.ID)
                {
                    Debug.WriteLine("User role before change: " + i.userRole);
                    i.userRole = crVm.NewUserRole;
                    Debug.WriteLine("User role after change: " + i.userRole);

                }
            }
        }

        [ChildActionOnly]
        public List<string> getRolesForUser(string username)
        {
            Debug.WriteLine("--- Recieved " + username + " to find roles for");
            var userRoles = new List<RolesViewModel>();
            var context = new ApplicationDbContext();
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            IEnumerable<string> roles = userManager.GetRoles(userStore.Users.First(s => s.UserName == username).Id);

            return roles.ToList();
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

        //Return role list as SelectListItem list
        public List<SelectListItem> getRoleSelectList()
        {
            List<SelectListItem> roleList = new List<SelectListItem>();
            foreach (var role in context.Roles.ToList())
            {
                roleList.Add(new SelectListItem
                {
                    Text = role.Name
                });
            }

            return roleList;
        }

        //Return user list as RegisterViewModel list
        public List<UserAccountsViewModel> getUsers()
        {
            List<UserAccountsViewModel> usersList = new List<UserAccountsViewModel>();
            var contextUsers = context.Users.ToList();
            //get all users, assign to user list view model
            foreach (var i in contextUsers)
            {

                UserAccountsViewModel userAccountVM = new UserAccountsViewModel();

                userAccountVM.FirstName = i.FirstName;
                userAccountVM.LastName = i.LastName;
                userAccountVM.Roles = getRolesForUser(i.UserName);
                userAccountVM.UserName = i.UserName;
                userAccountVM.ID = i.Id;
                

                foreach(var j in userAccountVM.Roles)
                {
                    Debug.WriteLine("For username: " + userAccountVM.UserName + ", role is: " + j);
                }
              
                usersList.Add(userAccountVM);

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