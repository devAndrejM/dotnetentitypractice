using System;
using System.Web.Mvc;
using ATM.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ATM.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContactFormSaysThanks()
        {
            var homeController = new HomeController();
            var result = homeController.Contact("I love your bank.") as ViewResult;
            Assert.IsNotNull("Thanks!", result.ViewBag.TheMessage);
        }
    }
}
