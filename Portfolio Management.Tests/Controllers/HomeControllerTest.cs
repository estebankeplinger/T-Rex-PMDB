﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portfolio_Management;
using Portfolio_Management.Controllers;
using Portfolio_Management.Models;
using System.Diagnostics;

namespace Portfolio_Management.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest: ApplicationBaseController
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        /*
         * Test user is logged in when they access home page
         */
         [TestMethod]
        public void testHomeOnError()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;
            var context = new ApplicationDbContext();
            var username = User.Identity.Name;
            
            //Assert
            if (Request.IsAuthenticated == false)
            {
                Assert.IsNull(username);
            }
            else
                Assert.IsNotNull(username);
        }

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    HomeController controller = new HomeController();

        //    // Act
        //    ViewResult result = controller.Contact() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}
    }
}
