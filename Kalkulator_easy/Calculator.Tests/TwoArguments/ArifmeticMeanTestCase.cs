using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class ArifmeticMeanTestsCase
    {
        [TestCase(20, 10, 15)]
        [TestCase(38, 2, 20)]
        [TestCase(9, 3, 6)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new ArifmeticMean();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}