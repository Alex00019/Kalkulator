using System;

namespace Calculator
{
    public class Cose : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the cose of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// cose of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}