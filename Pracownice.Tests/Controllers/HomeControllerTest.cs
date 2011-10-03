using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pracownice;
using Pracownice.Controllers;
using Pracownice.Tests.Db;

namespace Pracownice.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Try to generate new database
            System.Data.Entity.Database.SetInitializer(new SampleData());

            // Arrange
            HomeController controller = new HomeController();

            // Act
            //ViewResult result = controller.Index() as ViewResult;

            // Assert
            //Assert.AreEqual("Welcome to ASP.NET MVC!", result.ViewBag.Message);
        }

      
    }
}
