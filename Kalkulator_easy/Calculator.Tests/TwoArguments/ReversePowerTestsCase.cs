using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class LReversePowerTestsCase
    {
        [TestCase(5, 3, 1.709)]
        [TestCase(7, 2, 2.645)]
        [TestCase(9, 38, 1.059)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new ReversePower();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}