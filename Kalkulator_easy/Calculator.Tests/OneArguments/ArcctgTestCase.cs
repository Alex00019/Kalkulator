using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class ArcctgTestsCase
    {
        [TestCase(7, 0.141)]
        [TestCase(88, 0.011)]
        [TestCase(99, 0.010)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arcctg();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}