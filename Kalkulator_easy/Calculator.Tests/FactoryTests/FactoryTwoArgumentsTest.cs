using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.FactoryTests
{
    public class FactoryTwoArgumentTest
    {
        [TestCase("amount", typeof(Amount))]
        [TestCase("difference", typeof(Difference))]
        [TestCase("multiplication", typeof(Multiplication))]
        [TestCase("division", typeof(Division))]
        [TestCase("degreeTwo", typeof(DegreeTwoArguments))]
        [TestCase("logXAcrossY", typeof(LogOneByTwo))]
        [TestCase("remainderOfDivision", typeof(RemainderOfDivisio))]
        [TestCase("min", typeof(Min))]
        [TestCase("arifmeticMean", typeof(ArifmeticMean))]
        [TestCase("reversePower", typeof(ReversePower))]
        [TestCase("max", typeof(Max))]
        [TestCase("meanGeometric", typeof(MeanGeometric))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = FactoryTwoArguments.CreateCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
