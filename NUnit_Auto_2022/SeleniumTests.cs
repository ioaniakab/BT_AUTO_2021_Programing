﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests
    {

        //public string path = "C:\\Drivers";
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
             //driver = new ChromeDriver();
             driver = new EdgeDriver();
        }

        [Test]
        public void Test01()
        {  
            driver.Url = "https://google.com";
            driver.Navigate();
        }

        [Test]
        public void Test02()
        {
            driver.Url = "https://learn.digitalstack.ro";
            driver.Navigate();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
