using NUnit.Framework;
using System;

namespace Calculator.Tests.CalculateTest
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void TwoArgumentsTest()
        {
            var calculator = new Division();
            double arthalfour = calculator.Calculate(395, 5);
            Assert.AreEqual(79, arthalfour);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            var calculator = new Division();
            Assert.Throws<Exception>(() =>calculator.Calculate(395, 0));
  
        }
    }
}