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
        public string FullName;
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
            {
                var context = new ApplicationDbContext();
                var username = User.Identity.Name;

                if (!string.IsNullOrEmpty(username))
                { 
                    var user = context.Users.SingleOrDefault(u => u.UserName == username);
                    FullName = string.Concat(new string[] { user.FirstName, " ", user.LastName });
                    ViewData.Add("FullName", FullName); 
                    //System.Diagnostics.Debug.WriteLine("full name is: "+fullName);
                }
            }
            base.OnActionExecuted(filterContext);
        }
        public ApplicationBaseController()
        { }
        public string getCurrentUserFullName()
        {
            var context = new ApplicationDbContext();
            var username = User.Identity.Name;
            var user = context.Users.SingleOrDefault(u => u.UserName == username);
            return string.Concat(new string[] { user.FirstName, " ", user.LastName }); ;
        }


    }
}
