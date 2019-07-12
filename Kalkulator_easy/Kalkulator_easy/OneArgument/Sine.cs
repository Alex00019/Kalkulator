using System;

namespace Calculator
{
    public class Sine : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the sine of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// sine of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}

