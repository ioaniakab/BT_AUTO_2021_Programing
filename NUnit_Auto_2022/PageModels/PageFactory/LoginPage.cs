﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.PageFactory
{
    class LoginPage
    {
        //const string authPageText = "text-muted"; //class
        //const string usernameLabel = "#login-form > div:nth-child(1) > label"; //css
        // const string usernameInput = "input-login-username"; //id
        //const string usernameError = "#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"; // css
        //const string passwordLabel = "#login-form > div.form-group.row.row-cols-lg-true > label"; //css
        //const string passwordInput = "input-login-password"; // id
        //const string passwordError = "#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback";//css
        //const string submitButton = "btn btn-primary"; // class

        IWebDriver driver;
        // Page elements that are found automatically once the class is instantiated and page is loaded
        private IWebElement authPageTextElem => driver.FindElement(By.ClassName("text-muted"));
        private IWebElement usernameLabelElem => driver.FindElement(By.CssSelector("input-login-username"));
        private IWebElement usernameInputElem => driver.FindElement(By.Id("input-login-username"));
        private IWebElement usernameErrElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
        private IWebElement passwordLabelElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > label"));
        private IWebElement passwordInputElem => driver.FindElement(By.Id("input-login-password"));
        private IWebElement passwordErrElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));
        private IWebElement submitButtonElem => driver.FindElement(By.ClassName("btn btn-primary"));

        // returnt the text that appeart on the AUTH page to be checked in the test
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        public string CheckPage()
        {
            return authPageTextElem.Text;
        }
        
        public void Login (string user, string pass)
        {
            usernameErrElem.Clear();
            usernameInputElem.SendKeys(user);
            passwordInputElem.Clear();
            passwordInputElem.SendKeys(pass);
            submitButtonElem.Submit();
        }
    }
}
