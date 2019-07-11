using System;

namespace Calculator
{
    public class Division : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0) throw new Exception(" Деление на ноль ");
            return first / second;

        }
    }
}