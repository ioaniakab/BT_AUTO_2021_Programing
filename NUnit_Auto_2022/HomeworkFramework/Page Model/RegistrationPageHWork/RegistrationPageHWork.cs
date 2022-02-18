using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM.RegistrationPageHWork
{
    public class RegistrationPageHWork : BasePage
    {
        const string homeText = "#root > div > div.content > div > div > div > div > h1 > small"; //css selector
        const string registrationPage = "#root > div > div.sidebar > a:nth-child(3)"; // css
        const string usernameLabel = "#registration-form > div:nth-child(2) > label"; // css
        const string usernameInput = "input-username"; // id
        const string passwordLabel = "#registration-form > div:nth-child(3) > label"; // css
        const string passwordInput = "input-password"; // id
        const string confirmpasswordLabel = "#registration-form > div:nth-child(4) > label"; // css
        const string confirmpasswordInput = "input-password-confirm"; // id
        const string titleLabel = "#registration-form > div:nth-child(6) > label"; // css
        const string mrtitleLabel = "#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"; // css
        const string mstitleLabel = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"; // css
        const string firstnameLabel = "#registration-form > div:nth-child(7) > label"; // css
        const string firsnameInput = "input-first-name"; // id
        const string lastnameLabel = "#registration-form > div:nth-child(8) > label"; // css
        const string lastnameInput = "input-last-name"; // id
        const string emailLabel = "#registration-form > div:nth-child(9) > label"; // css
        const string emailInput = "input-email";
        const string dobLabel = "#registration-form > div:nth-child(10) > label";
        const string dobInput = "input-dob";
        const string nationalityLabel = "#registration-form > div:nth-child(11) > label";
        const string nationalityInput = "input-nationality";
        const string termsInput = "terms";
        const string submitRegBtn = "#registration-form > div:nth-child(13) > div.text-left.col-lg > button";

        const string usernameerr = "#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback";
        const string passworderr = "#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback";
        const string confirmpasserr = "#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback";
        const string firstnameerr = "#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback";
        const string lastnameerr = "#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback";
        const string emailerr = "#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback";
        const string termserr = "#registration-form > div:nth-child(12) > div.text-left.col-lg > div > div";

        public RegistrationPageHWork(IWebDriver driver) : base(driver)
        {
        }

        public string CheckRegPage()
        {
            return driver.FindElement(By.CssSelector(homeText)).Text;
        }

        

        public void RegistrationUser(string user, string pass, string confpass, string titleVal, string fname, string lname, string emailreg, string dob, string natio,
            string terms, string userErr, string passErr, string confpassErr, string fnameErr, string lnameErr, string emailErr, string eulaErr)
        {
            var usernameInputElement = driver.FindElement(By.Id(usernameInput));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(user);
            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(pass);
            var confirmpasswordInputElement = driver.FindElement(By.Id(confirmpasswordInput));
            confirmpasswordInputElement.Clear();
            confirmpasswordInputElement.SendKeys(confpass);

            if (titleVal == "Mr")
            {
                var mrtitleLabelSelect = driver.FindElement(By.CssSelector(mrtitleLabel));
                mrtitleLabelSelect.Click();
            }

            if (titleVal == "Ms")
            {
                var mstitleLabelSelect = driver.FindElement(By.CssSelector(mstitleLabel));
                mstitleLabelSelect.Click();
            }

            var firstnameInputElement = driver.FindElement(By.Id(firsnameInput));
            firstnameInputElement.Clear();
            firstnameInputElement.SendKeys(fname);
            var lastnameInputElement = driver.FindElement(By.Id(lastnameInput));
            lastnameInputElement.Clear();
            lastnameInputElement.SendKeys(lname);

            var emailInputElement = driver.FindElement(By.Id(emailInput));
            emailInputElement.Clear();
            emailInputElement.SendKeys(emailreg);

            var dobInputElement = driver.FindElement(By.Id(dobInput));
            dobInputElement.Clear();
            dobInputElement.SendKeys(dob);

            var nationalityInputElement = driver.FindElement(By.Id(nationalityInput));
            nationalityInputElement.SendKeys(natio);

            if (terms == "true")
            {
                var termsInputElement = driver.FindElement(By.Id(termsInput));
                termsInputElement.Click();
            }

            var submitRegBtnElement = driver.FindElement(By.CssSelector(submitRegBtn));
            submitRegBtnElement.Submit();


        }
        
        public string UsernameERR()
        {
            var usernameErrElement = driver.FindElement(By.CssSelector(usernameerr));
            return usernameErrElement.Text;
        }

        public string PasswordErr()
        {
            var passwordErrElement = driver.FindElement(By.CssSelector(passworderr));
            return passwordErrElement.Text;
        }
        public string ConfPasswordErr()
        {
            var confpasswordErrElement = driver.FindElement(By.CssSelector(confirmpasserr));
            return confpasswordErrElement.Text;
        }
        public string FirstNamedErr()
        {
            var firstnamerErrElement = driver.FindElement(By.CssSelector(firstnameerr));
            return firstnamerErrElement.Text;
        }
        public string LastNamedErr()
        {
            var lastNameErrElement = driver.FindElement(By.CssSelector(lastnameerr));
            return lastNameErrElement.Text;
        }
        public string EmailErr()
        {
            return driver.FindElement(By.CssSelector(emailerr)).Text;
        }
        public string EulaErr()
        {
            var eulaErrElement = driver.FindElement(By.CssSelector(termserr));
            return eulaErrElement.Text;
        }
              
    }
}
