using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Auto_2022;
using System;

namespace MSTest_Auto_2022
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void SetUp()
        {
            Console.WriteLine("Before every test");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Testing...");
            Calculator c = new Calculator(100, 200, '+');
            Assert.AreEqual(300, c.Compute());
        }

        [TestCleanup]
        public void TearDown()
        {
            Console.WriteLine("After every test");
        }
    }
}
