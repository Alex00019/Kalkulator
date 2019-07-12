using System;

namespace Calculator
{
    public class Exp : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the exponent of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// exponent
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}