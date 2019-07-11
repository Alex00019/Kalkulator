using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class DivisionTestsCase
    {
        [TestCase(20, 10, 2)]
        [TestCase(22, 2, 11)]
        [TestCase(9, 9, 1)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}