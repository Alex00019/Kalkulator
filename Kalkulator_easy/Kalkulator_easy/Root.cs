using System;

namespace Calculator
{
    class Root: IOneArgumentsCalculator
    {
        public double Calculate(double one)
        {
            return Math.Sqrt(one);
        }

    }
}
