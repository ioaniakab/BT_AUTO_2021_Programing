using NUnit_Auto_2022;
using System;
using Xunit;
using Xunit.Abstractions;

namespace XUnit_Auto_2022
{
    public class UnitTest1 : IDisposable
    {

        private readonly ITestOutputHelper testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {

            this.testOutputHelper = testOutputHelper;
            testOutputHelper.WriteLine("Setup method!");
        }

        public void Dispose()
        {
            testOutputHelper.WriteLine("TearDown!!");
        }

        //[Fact] is for tests without parameters, Theory is for tests with parameters (test data)
        [Theory]
        [InlineData(50,100,'-',-50)]
        [InlineData(-50,-100,'-',150)]
        public void Test1(double a, double b, char op, double res)
        {
            testOutputHelper.WriteLine("My test");
            Calculator c = new Calculator(a,b,op);
            Assert.Equal(-50, c.Compute());
        }



    }
}
