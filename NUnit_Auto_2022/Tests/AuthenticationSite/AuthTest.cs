﻿using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022.Tests.AuthenticationSite
{
    class AuthTest : BaseTest
    {

        string url = FrameworkConstants.GetUrl();

      
        // Test auth with Page Object model
        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url+"login");
            //driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/login");
            // This is beacuse we have 2 classes named LoginPage one on POM other on PageFactory
            // In real life framework you will have just one type of desigm pattern (POM/PF)
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);
            Console.WriteLine(lp.CheckPage()+" "+url);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }

        // Test auth with Page factory
        [Test]
        public void BasicAuthPf()
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }


    }
}
