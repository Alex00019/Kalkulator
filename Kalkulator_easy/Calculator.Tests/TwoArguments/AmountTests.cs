using NUnit.Framework;

namespace Calculator.Tests.CalculateTest
{
    [TestFixture]
    public class AmountTests
    {
        [Test]
        public void TwoArgumentsTest()
        {
            var calculator = new Amount();
            double arthalTwo = calculator.Calculate(4,7);
            Assert.AreEqual(11, arthalTwo);
        }

    }
}
