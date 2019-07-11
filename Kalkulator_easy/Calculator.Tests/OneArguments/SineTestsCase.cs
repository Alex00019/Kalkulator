using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class SineTestsCase
    {
        [TestCase(0, 0.000)]
        [TestCase(8, 0.989)]
        [TestCase(-20, -0.912)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Sine();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}