using NUnit.Framework;
using System;

namespace Calculator.Tests.CalculateTest
{
    public class TwoDivideXTests
    {
        [TestCase(10, 0.2)]
        [TestCase(1, 2)]
        [TestCase(-1, -2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TwoDivideX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [Test]
        public void TwoDivideXByZeroTest()
        {
            var calculator = new OneDivideByX();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}