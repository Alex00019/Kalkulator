using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class ArctanTestsCase
    {
        [TestCase(72, 1.556)]
        [TestCase(3, 1.249)]
        [TestCase(-1, -0.785)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arctan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}