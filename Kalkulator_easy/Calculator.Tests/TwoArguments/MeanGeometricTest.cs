using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class MeanGeometricTest
    {
        [TestCase(20, 8, 21.54)]
        [TestCase(5, 3, 5.830)]
        [TestCase(-18, -30, 34.985)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new MeanGeometric();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}