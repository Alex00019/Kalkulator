using System;

namespace Calculator
{
    public class Root: IOneArgumentsCalculator
    {
        public double Calculate(double one)
        {
            return Math.Sqrt(one);
        }
    }
}
