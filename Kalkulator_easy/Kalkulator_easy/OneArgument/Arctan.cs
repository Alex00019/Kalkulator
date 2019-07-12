using System;

namespace Calculator
{
    public class Arctan : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the arc tangenth of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// arc tangenth of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}
