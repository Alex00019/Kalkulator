using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class LogarithmTests
    {
        [TestCase(0, 0)]
        [TestCase(3, 4)]
        [TestCase(-7, -2)]
        public void CalculateTest( double firstValue, double expected)
        {
            var calculator = new LogarithmTen();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}

