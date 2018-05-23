using Microsoft.VisualStudio.TestTools.UnitTesting;
using Portfolio_Management.Controllers;
using Portfolio_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Portfolio_Management.Controllers.Tests
{
 

    [TestClass()]
    public class Adm_AgencyControllerTests
    {
        private PMDataEntities db = new PMDataEntities();

        [TestMethod()]
        public void IndexTestNotNull()
        {
            // Arrange
            Adm_AgencyController controller = new Adm_AgencyController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        //
        [TestMethod()]
        public void DetailsTestNotNull()
        {

            // Arrange
            Adm_AgencyController controller = new Adm_AgencyController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }


    }
}