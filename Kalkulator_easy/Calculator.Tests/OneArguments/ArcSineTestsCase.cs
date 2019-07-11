using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class ArcSineTestsCase
    {
        [TestCase(0, 0.000)]
        [TestCase(1, 1.570)]
        [TestCase(-1, -1.570)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arcsine();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}