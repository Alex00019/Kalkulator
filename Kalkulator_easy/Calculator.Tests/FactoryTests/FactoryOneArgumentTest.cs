using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.FactoryTests
{
    public class FactoryOneArgumentTest
    {
        [TestCase("Root", typeof(Root))]
        [TestCase("Degree", typeof(Degree))]
        [TestCase("sine", typeof(Sine))]
        [TestCase("tan", typeof(Tangent))]
        [TestCase("arcsine", typeof(Arcsine))]
        [TestCase("arctan", typeof(Arctan))]
        [TestCase("oneDivideByX", typeof(OneDivideByX))]
        [TestCase("cose", typeof(Cose))]
        [TestCase("exp", typeof(Exp))]
        [TestCase("arccose", typeof(Arcose))]
        [TestCase("arcctg", typeof(Arcctg))]
        [TestCase("catangent", typeof(Catangent))]
        [TestCase("logarithmTen", typeof(LogarithmTen))]
        [TestCase("twoDivide", typeof(TwoDivideX))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = FactoryOneArgument.CreateCalculate(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}
