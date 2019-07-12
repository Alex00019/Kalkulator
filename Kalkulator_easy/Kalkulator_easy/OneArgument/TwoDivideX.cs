using System;

namespace Calculator
{
    public class TwoDivideX : IOneArgumentsCalculator
    {
        /// <summary>
        /// two divide by argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// two divide by argument
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument == 0) throw new Exception(" Деление на ноль ");
            return 2 / argument;
        }
    }
}
