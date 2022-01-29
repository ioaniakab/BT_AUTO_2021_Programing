using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    [TestFixture(typeof(ChromeDriver))]
    //[TestFixture(typeof(EdgeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    public class HomeworkRegAndCookie<MultipleDrivers> where MultipleDrivers : IWebDriver, new()
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;
        
        public string cookieValue { get; private set; }

        [SetUp]
        public void Setup()
        {
            driver = new MultipleDrivers();
            driver.Manage().Window.Maximize();
        }

        [TestCase("Janos", "1234asdf", "1234asdf", "Mr", "Ju", "Jo", "email@email.aa", "01/01/1990", "Angolan", true, "", "", "", "", "", "", "")]
        [TestCase("a", "1234asdf", "1234asdf", "Ms", "Ju", "Jo", "email@email.aa", "", "Colombian", true, "Minimum of 4 characters is required!", "", "", "", "", "", "")]
        [TestCase("Janos", "1234", "1234asdf", "Ms", "Vaslie", "Jo", "email@email.aa", "01/01/1990", "Dutchwoman", true, "", "Minimum of 8 characters is required!", "Passwords do not match!", "", "", "", "")]
        [TestCase("Janos", "1234asdf", "1234asd", "Mr", "Ju", "Jo", "email@email.aa", "01/01/1990", "Romanian", true, "", "", "Passwords do not match!", "", "", "", "")]
        [TestCase("Janos", "1234asdf", "1234asdf", "Mr", "Ju", "Jo", "email@email.aa", "01/01/1990", "Romanian", false, "", "", "", "", "", "", "You need to accept our T&C!")]
        [TestCase("Janos", "1234asdf", "1234asdf", "Mr", "Ju", "Jo", "email@email.aa", "", "Emirian", true, "", "", "", "", "", "", "")]
        [TestCase("Janos", "1234asdf", "1234asdf", "", "Ju", "Jo", "email@email.aa", "01/01/1990", "Romanian", true, "", "", "", "", "", "", "")]
        [TestCase("Janos", "1234asdf", "1234asdf", "Ms", "Ju", "Jo", "", "01/01/1990", "Romanian", true, "", "", "", "", "", "Email is required!", "")]
        [TestCase("Janos", "1234asdf", "1234asdf", "Ms", "Ju", "Jo", "email@email.aa", "01/01/19900", "Romanian", true, "", "", "", "", "", "", "")]
        [TestCase("Janos", "1234asdf", "1234asdf", "Ms", "Ju", "Jo", "email@email.aa", "01/01/2222", "Romanian", true, "", "", "", "", "", "", "")]

        public void RegTests(string user, string pass, string confpass, string titleVal, string fname, string lname, string emailreg, string dob, string natio,
            bool terms, string userErr, string passErr, string confpassErr, string fnameErr, string lnameErr, string emailErr, string eulaErr)
        {
            driver.Navigate().GoToUrl(url);
            var homeText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div > div > div > h1 > small"));
            Assert.AreEqual("Home", homeText.Text);

            IWebElement registrationLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(3)"));
            Assert.AreEqual("Registration", registrationLink.Text);
            registrationLink.Click();

            var username = driver.FindElement(By.Id("input-username"));
            var password = driver.FindElement(By.Id("input-password"));
            var confirmpass = driver.FindElement(By.Id("input-password-confirm"));
            var title = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > label"));
            Assert.AreEqual("Title", title.Text);

            var title1 = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"));
            var title2 = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));

            var firstname = driver.FindElement(By.Id("input-first-name"));
            var lastname = driver.FindElement(By.Id("input-last-name"));
            var email = driver.FindElement(By.Id("input-email"));
            var dateofbirth = driver.FindElement(By.Id("input-dob"));
            var nationality = driver.FindElement(By.Id("input-nationality"));
            var nation = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(11) > label"));
            Assert.AreEqual("Nationality", nation.Text);

            var termscond = driver.FindElement(By.Id("terms"));
            var submitregistration = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));

            var usernameerr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            var passworderr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
            var confirmpasserr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
            var firstnameerr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
            var lastnameerr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
            var emailerr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            confirmpass.Clear();
            confirmpass.SendKeys(confpass);

            if (titleVal == "Mr")
            {
                title1.Click();
            }

            if (titleVal == "Ms")
            {
                title2.Click();
            }

            firstname.Clear();
            firstname.SendKeys(fname);

            lastname.Clear();
            lastname.SendKeys(lname);

            email.Clear();
            email.SendKeys(emailreg);

            dateofbirth.Clear();
            dateofbirth.SendKeys(dob);

            if (dob.Length > 10 || dob == "" || DateTime.Compare(DateTime.Parse(dob), DateTime.Today) > 0)
            {
                Console.WriteLine("No date of birth or not correct date of birth, without displaying an error");
            }

            nationality.SendKeys(natio);

            if (terms == true)
            {
                termscond.Click();
            }

            submitregistration.Submit();
            if (terms == false)
            {
                var termsErr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(12) > div.text-left.col-lg > div > div"));
                Assert.AreEqual(eulaErr, termsErr.Text);
            }
            Assert.AreEqual(userErr, usernameerr.Text);
            Assert.AreEqual(passErr, passworderr.Text);
            Assert.AreEqual(confpassErr, confirmpasserr.Text);
            Assert.AreEqual(fnameErr, firstnameerr.Text);
            Assert.AreEqual(lnameErr, lastnameerr.Text);
            Assert.AreEqual(emailErr, emailerr.Text);
        }

        [TestCase("", "Vasile", "01234", "emai@email.com", "1234asd", "1234asdf", true, true, "Va rugam sa completati prenumele dvs.")]
        [TestCase("Ion", "", "01234", "emai@email.com", "1234asd", "1234asdf", true, true, "Va rugam sa completati numele dvs.")]
        [TestCase("Ion", "Vasile", "", "emai@email.com", "1234asd", "1234asdf", true, true, "Va rugam sa completati numarul dvs. de telefon")]
        [TestCase("Ion", "Vasile", "01234", "", "1234asd", "1234asdf", true, true, "Va rugam sa completati adresa dvs. de e-mail")]
        [TestCase("Ion", "Vasile", "01234", "mail@mail.com", "", "1234asdf", true, true, "Va rugam sa completati parola")]
        [TestCase("Ion", "Vasile", "01234", "mail@mail.com", "1234asdf", "", true, true, "Parolele nu corespund")]
        [TestCase("Ioon", "Vasile", "01234", "email@email.com", "1234asdf", "1234asdf", true, false, "Pentru a va inregistra trebuie sa fiti de acord cu termenii si conditiile de utilizare.")]
        public void VexioNewUserTest(string userName, string userLName, string userPhone, string userEmail, string pass, string repPass, bool letter, bool eula,
            string error)
        {
            string url = protocol + "s://www.vexio.ro/account/login/";
            driver.Navigate().GoToUrl(url);

            var body = driver.FindElement(By.CssSelector("#cookies-consent > div > div > div:nth-child(2) > div > div.accept-cookies.col-xs-offset-4.col-xs-4.col-sm-offset-0.col-sm-3.pull-right.col-lg-2.text-right > button"));
            Assert.AreEqual("Accept", body.Text);
            body.Click();

            var newUserPage = driver.FindElement(By.CssSelector("#register > formfield > legend"));
            Assert.AreEqual("Sunt client nou", newUserPage.Text);

            var fname = driver.FindElement(By.Id("newfirstname"));
            var lname = driver.FindElement(By.Id("newlastname"));
            var phoneNo = driver.FindElement(By.Id("telephone"));
            var email = driver.FindElement(By.Id("newemail"));
            var password = driver.FindElement(By.Id("newpassword"));
            var repetPassword = driver.FindElement(By.Id("newpasswordretype"));
            var newsletter = driver.FindElement(By.Id("newsletter"));
            var eulacheck = driver.FindElement(By.Id("agree"));
            var submitBtn = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(9) > div > button"));

            fname.Clear();
            fname.SendKeys(userName);

            lname.Clear();
            lname.SendKeys(userLName);

            phoneNo.Clear();
            phoneNo.SendKeys(userPhone);

            email.Clear();
            email.SendKeys(userEmail);

            password.Clear();
            password.SendKeys(pass);

            repetPassword.Clear();
            repetPassword.SendKeys(repPass);

            if (letter == true)
            {
                newsletter.Click();
            }

            if (eula == true)
            {
                eulacheck.Click();
            }

            submitBtn.Click();

            if (userName == null)
            {
                var userFnameErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li"));
                Assert.AreEqual(error, userFnameErr.Text);
            }

            if (userLName == null)
            {
                var userLNErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li"));
                Assert.AreEqual(error, userLNErr.Text);
            }

            if (userPhone == null)
            {
                var userPhoneErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li"));
                Assert.AreEqual(error, userPhoneErr.Text);
            }
            if (userEmail == null)
            {
                var userEmailErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li"));
                Assert.AreEqual(error, userEmailErr.Text);
            }
            if (pass == null)
            {
                var passErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li"));
                Assert.AreEqual(error, passErr.Text);
            }
            if (repPass == null)
            {
                var repPassErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li"));
                Assert.AreEqual(error, repPassErr.Text);
            }
            if (eula == false)
            {
                var eulaErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul"));
                Assert.AreEqual(error, eulaErr.Text);
            }


        }


        [TestCase("", "", "Va rugam sa completati adresa dvs. de e-mail!\r\nVa rugam sa completati parola\r\nParola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite.")]
        [TestCase("", "abcd", "Va rugam sa completati adresa dvs. de e-mail!\r\nParola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite.")]
        [TestCase("aaa@email.com", "", "Va rugam sa completati parola\r\nParola sau username-ul sunt gresite. Accesul va fi blocat dupa mai multe incercari nereusite.")]
        public void VexioLogin(string email, string pass, string errMsg)
        {

            string url = protocol + "s://www.vexio.ro/account/login/";
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > h1"));
            Assert.AreEqual("Autentificare", pageText.Text);

            var emailInput = driver.FindElement(By.Id("email"));
            var passwordInput = driver.FindElement(By.Id("password"));
            var submitBtn = driver.FindElement(By.CssSelector("#login > formfield > div:nth-child(5) > div > button"));

            emailInput.Clear();
            emailInput.SendKeys(email);

            passwordInput.Clear();
            passwordInput.SendKeys(pass);

            submitBtn.Submit();

            if (email == "" && pass == "")
            {
                var loginErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul"));
                Assert.AreEqual(errMsg, loginErr.Text);
            }
        }

       
        [Test]
        public void CookieTests()
        {
            driver.Navigate().GoToUrl(url);

            var homePage = driver.FindElement(By.CssSelector("#root > div > div.content > div > div > div > div > h1 > small"));
            Assert.AreEqual("Home", homePage.Text);

            var cookieMenu = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(5)"));
            cookieMenu.Click();

            var pageName = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("The gibberish talking cookie", pageName.Text);

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);

            var setButton = driver.FindElement(By.Id("set-cookie"));
            Assert.AreEqual("Set the cookie", setButton.Text);
            var delButton = driver.FindElement(By.Id("delete-cookie"));
            Assert.AreEqual("Remove the cookie", delButton.Text);

            setButton.Click();

            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);

            var cookieVal = driver.FindElement(By.Id("cookie-value")).Text;
            Assert.AreEqual(cookieVal, cookies.AllCookies[0].Value);

            delButton.Click();
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);

            Assert.AreEqual(cookies.AllCookies.Count, 0);

        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
