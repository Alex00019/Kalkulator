using System;

namespace Calculator
{
    public class OneDivideByX : IOneArgumentsCalculator
    {
        /// <summary>
        /// revers divide argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// revers
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument == 0) throw new Exception(" Деление на ноль ");
            return 1 / argument;
        }
    }
}
