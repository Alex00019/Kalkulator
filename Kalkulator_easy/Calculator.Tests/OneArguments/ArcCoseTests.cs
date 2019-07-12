using NUnit.Framework;
using System;

namespace Calculator.Tests.CalculateTest
{
    public class ArcCosTests
    {
        [TestCase(1, 0)]
        [TestCase(0, 1.570)]
        [TestCase(-1, 3.141)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arcos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
        [Test]
        public void ArcCoseByInvalidValueTest()
        {
            var calculator = new Arcos();
            Assert.Throws<Exception>(() => calculator.Calculate(20));

        }
    }
}