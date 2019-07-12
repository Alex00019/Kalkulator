using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    public class ExpTests
    {
        [TestCase(27, 532048240601.799)]
        [TestCase(5, 148.413)]
        [TestCase(12, 162754.791)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Exp();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}