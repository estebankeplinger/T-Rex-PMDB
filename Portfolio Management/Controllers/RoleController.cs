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
        // Returns Users
        // </summary>
        // <param name="Role"></param>
        // <returns></returns>
        //public ActionResult usersInRole()
        //{
        //    //var userRoles = new List<UsersInRoleViewModel>();

        //    //Debug.WriteLine("Writing user roles: \n");
        //    //foreach (var i in userRoles)
        //    //{
        //    //    Debug.WriteLine(i);
        //    //}

        //    var context = new ApplicationDbContext();
        //    //var userStore = new UserStore<ApplicationUser>(context);
        //    //var userManager = new UserManager<ApplicationUser>(userStore);

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            
        //    //foreach (var user in userStore.Users)
        //    //{
        //    //    var r = new UsersInRoleViewModel()
        //    //    {
        //    //        userID = user.Id,
        //    //        username = user.UserName,
        //    //        role = string.Join(",", userManager.GetRoles(user.Id))
        //    //    };
        //    //}

        //    //var r = roleManager.Roles.ToList();

        //    var roleList = context.Roles.AsEnumerable();
            
        //    //foreach (var i in roleList)
        //    //{

        //    //    Debug.WriteLine("Reading " + i.Name + i.Id + i.Users);
        //    //    //foreach(var j in context.Users.ToList())
        //    //    //{
        //    //    //    Debug.WriteLine("Reading " + j.RoleName);
        //    //    //    if(j.RoleName == i.Id)
        //    //    //    {
        //    //    //        Debug.WriteLine("Matches: {0}, {1}" +j.UserName,j.RoleName);
        //    //    //    }
        //    //    //}
        //    //}

        //    //foreach (var j in context.Users.ToList())
        //    //{
        //    //    Debug.WriteLine("TEST: " + j.LastName + " " + j.UserName + " " + j.RoleName);
        //    //}

        //    return View(roleList);
        //}


        ////public ActionResult AssignRole()
        ////{
        ////    var context = new ApplicationDbContext();
        ////    IEnumerable<AssignUserToRoleViewModel> userRoles;
            
        ////}

        ////public ActionResult AssignRole(RoleViewModels model)
        ////{
        ////    var context = new ApplicationDbContext();
        ////    List<RoleViewModels> userList = new List<RoleViewModels>();
        ////    var roles = context.Roles.ToList();
        ////    var users = context.Users.ToList();

        ////    foreach(var i in roles)
        ////    {
        ////        foreach(var j in users)
        ////        {
                    
        ////        }
        ////    }
        ////}
        
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