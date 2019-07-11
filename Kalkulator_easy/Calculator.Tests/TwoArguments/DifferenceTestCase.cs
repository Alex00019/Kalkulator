using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class DifferenceTestsCase
    {
        [TestCase(20, 10, 10)]
        [TestCase(55, 2, 53)]
        [TestCase(9, 8, 1)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new Difference();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}