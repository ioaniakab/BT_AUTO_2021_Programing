using NUnit.Framework;
using System;

namespace NUnit_Auto_2022
{
    [TestFixture(15, 35)]
    [TestFixture(25, 255)]
    public class Tests
    {
        int x;
        int y;

        public Tests(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        [OneTimeSetUp]
        public void SetupOnce()
        {
            //Console.WriteLine("Run me at every test !!");
            TestContext.Out.WriteLine("This method runs only once for all tests!");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Run me at every test !!");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test(Description = "Test2 with 2 numbers")]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Console.WriteLine("First value is {0} second value is {1} ", x, y);
        }

        [TestCase(69, 24, 199)]
        [TestCase(-100, -200, -333)]
        public void Test3(int a, int b, int c)
        {
            Console.WriteLine("The sum is {0}", a + b + c + x + y);
            //Assert.AreEqual(-583, a + b + c + x + y, 0, "THe test failed!!!");
            //Assert.That(a, Is.InRange(100, 500));
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Let's do some cleanup for every test !");
        }

        [OneTimeTearDown]
        public void GeneralCleanUp()
        {
            TestContext.Out.WriteLine("Is the final ... cleanup ! :)");
        }
    }
}