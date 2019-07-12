using NUnit.Framework;
using System;

namespace Calculator.Tests.CalculateTest
{
    public class ArcSinTests
    {
        [TestCase(0, 0.000)]
        [TestCase(1, 1.570)]
        [TestCase(-1, -1.570)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arcsine();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void ArcSineInvalidValueTest()
        {
            var calculator = new Arcsine();
            Assert.Throws<Exception>(() => calculator.Calculate(234));
        }
    }
}
