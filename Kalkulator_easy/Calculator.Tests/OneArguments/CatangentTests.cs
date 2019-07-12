using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class CatangentTests
    {
        [TestCase(65, 0.015)]
        [TestCase(99, 0.010)]
        [TestCase(354, 0.002)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Catangent();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}