using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void TwoArgumentsTest()
        {
            var calculator = new Division();
            double arthalfour = calculator.Calculate(395, 5);
            Assert.AreEqual(79, arthalfour);
        }

    }
}