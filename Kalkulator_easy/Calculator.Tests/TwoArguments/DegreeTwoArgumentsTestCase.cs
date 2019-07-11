using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class DegreeTwoArgumentsTestsCase
    {
        [TestCase(2, 10, 1024)]
        [TestCase(69, 2, 4761)]
        [TestCase(8, 3, 512)]
        public void CalculateTest(
    double firstValue,
    double secondValue,
    double expected)
        {
            var calculator = new DegreeTwoArguments();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}