using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class TangentTestsCAse
    {
        [TestCase(0, 0.000)]
        [TestCase(6, -0.291)]
        [TestCase(-7, -0.871)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Tangent();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}