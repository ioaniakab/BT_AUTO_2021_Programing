using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class EcomTestSite
    {
        IWebDriver driver;
        
        // https://www.abdcomputer.ro/account/login/

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.abdcomputer.ro");
        }
        [Test]
        public void LoginTest()
        {

        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
