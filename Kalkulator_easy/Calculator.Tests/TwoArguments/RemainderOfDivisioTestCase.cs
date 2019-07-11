using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class RemainderOfDivisioTestsCase
    {
        [TestCase(22, 3, 1)]
        [TestCase(62, 5, 2)]
        [TestCase(9, 9, 0)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new RemainderOfDivisio();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}