using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class DegreeTests
    {
        [TestCase(65, 4225)]
        [TestCase(99, 9801)]
        [TestCase(50, 2500)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Degree();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}