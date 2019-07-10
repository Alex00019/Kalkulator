using System;

namespace Calculator
{
    class Degree : IOneArgumentsCalculator
    {
        public double Calculate(double one)
        {
            return Math.Pow(one, 2);
        }
    }
}
