using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest
    {
        IWebDriver driver;

        string url = FrameworkConstants.GetUrl();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        // Test auth with Page with Page Object Model
        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url + "login");
            //this is beacuse we have 2 classes named LoginPage one on POM other PageFactory
            // In real life framework you will have just one type of design patter (POM/PF)
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }
        //Test auth with Page Factory

        [Test]
        public void BasicAuthPf()
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
