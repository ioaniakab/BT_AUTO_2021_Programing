using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM.RegistrationPageHWork;
using NUnit_Auto_2022.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022.Tests.HomeworkTests.RegistrationTests
{
    class RegistrationTests : BaseTest
    {
        string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetRegistrationCredentialsDataCsv()
        {
            string path = "TestData\\registrationcredentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8],
                            values[9], values[10], values[11], values[12], values[13], values[14], values[15], values[16]);
                    }
                    index++;
                }
            }
        }

        [Test, TestCaseSource("GetRegistrationCredentialsDataCsv")]
        public void RegistrationNew(string user, string pass, string confpass, string titleVal, string fname, string lname, string emailreg, string dob, string natio,
            string terms, string userErr, string passErr, string confpassErr, string fnameErr, string lnameErr, string emailErr, string eulaErr)
        {
            driver.Navigate().GoToUrl(url + "registration");
            RegistrationPageHWork rp = new RegistrationPageHWork(driver);
            Assert.AreEqual("Registration", rp.CheckRegPage());
            
            rp.RegistrationUser(user, pass, confpass, titleVal, fname, lname, emailreg, dob, natio, terms, userErr, passErr, confpassErr, fnameErr, lnameErr, emailErr, eulaErr);

        }
    }
}
