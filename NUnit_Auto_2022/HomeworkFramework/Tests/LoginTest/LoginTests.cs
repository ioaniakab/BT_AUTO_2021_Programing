using NUnit.Framework;
using NUnit_Auto_2022.Tests.Homework_Framework.LandingPage;
using NUnit_Auto_2022.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022.Tests.HomeworkTests
{
    class LoginTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetLoginCredentialsDataCsv()
        {
            string path = "TestData\\credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1]);
                    }
                    index++;
                }
            }
        }

        [Test, TestCaseSource("GetLoginCredentialsDataCsv")]
        public void LoginHWork(string username, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPageHWork lp = new LoginPageHWork(driver);
            Assert.AreEqual("Authentication", lp.CheckMainPage());
            lp.Login(username, password);
        }
    }
}
