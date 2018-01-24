using Portfolio_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio_Management.Controllers;


namespace Portfolio_Management.Controllers
{
    public class ApplicationBaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
                System.Diagnostics.Debug.WriteLine("User not null");

            {
                var context = new ApplicationDbContext();
                var username = User.Identity.Name;
                System.Diagnostics.Debug.WriteLine("username: " +username);

                if (!string.IsNullOrEmpty(username))
                {
                    System.Diagnostics.Debug.WriteLine("username not empty");
                    var user = context.Users.SingleOrDefault(u => u.UserName == username);
                    string fullName = string.Concat(new string[] { user.FirstName, " ", user.LastName });
                    ViewData.Add("FullName", fullName);
                    System.Diagnostics.Debug.WriteLine("fname: " + user.FirstName+", lname: "+user.LastName);
                    System.Diagnostics.Debug.WriteLine("full name is: "+fullName);
                }
            }
            base.OnActionExecuted(filterContext);
        }
        public ApplicationBaseController()
        { }
    }
}