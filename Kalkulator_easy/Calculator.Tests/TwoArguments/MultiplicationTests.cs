using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void TwoArgumentsTest()
        {
            var calculator = new Multiplication();
            double arthal = calculator.Calculate(3, 9);
            Assert.AreEqual(27, arthal);
        }

    }
}
