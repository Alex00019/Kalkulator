using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class ArcCoseTestsCase
    {
        [TestCase(1, 0)]
        [TestCase(0, 1.570)]
        [TestCase(-20, -0.05)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arcose();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}