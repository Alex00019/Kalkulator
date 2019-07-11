using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class MultiplicationTestsCase
    {
        [TestCase(8, 9, 72)]
        [TestCase(22, 2, 44)]
        [TestCase(9, 9, 81)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}