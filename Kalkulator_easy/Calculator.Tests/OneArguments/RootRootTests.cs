using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class RootRootTests
    {
        [TestCase(35, 5.916)]
        [TestCase(87, 9.327)]
        [TestCase(4, 2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Root();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}