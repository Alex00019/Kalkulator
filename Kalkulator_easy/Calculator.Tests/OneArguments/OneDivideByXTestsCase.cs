﻿using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    public class OneDivideByXTestsCase
    {
        [TestCase(5, 0.2)]
        [TestCase(10, 0.1)]
        [TestCase(-20, -0.05)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new OneDivideByX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}