using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class MaxTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 4)]
        [TestCase(-7, -2, -2)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}


