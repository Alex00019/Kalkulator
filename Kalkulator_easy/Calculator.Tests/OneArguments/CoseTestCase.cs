using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class CoseTestsCase
    {
        [TestCase(999, 0.999)]
        [TestCase(69, 0.993)]
        [TestCase(233, 0.866)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Cose();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}