using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DifferenceTests
    {
        [Test]
        public void TwoArgumentsTest()
        {
            var calculator = new Difference();
            double arthalth = calculator.Calculate(6, 5);
            Assert.AreEqual(1, arthalth);
        }

    }
}