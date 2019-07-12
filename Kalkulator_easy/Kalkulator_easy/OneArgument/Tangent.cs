using System;

namespace Calculator
{
    public class Tangent : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the tangenth of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// tangenth of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
