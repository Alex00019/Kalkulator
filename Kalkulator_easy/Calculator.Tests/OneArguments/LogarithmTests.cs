using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class LogarithmTests
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        public void CalculateTest( double firstValue, double expected)
        {
            var calculator = new LogarithmTen();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

