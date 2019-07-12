using System;

namespace Calculator
{
    public class LogarithmTen : IOneArgumentsCalculator
    {
        /// <summary>
        /// decimal logarithm
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// decimal logarithm one by two arguments
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Log10(argument);
        }
    }
}