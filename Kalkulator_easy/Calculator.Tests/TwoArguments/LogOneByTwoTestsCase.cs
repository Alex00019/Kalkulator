using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class LogOneByTwoTestsCase
    {
        [TestCase(8, 2, 3)]
        [TestCase(27, 3, 3)]
        [TestCase(64, 4, 3)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new LogOneByTwo();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}