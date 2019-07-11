using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class MinTestCase
    {
        [TestCase(5, 2, 2)]
        [TestCase(10, 15, 10)]
        [TestCase(-6.5, -9.24, -9.24)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Min();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}

