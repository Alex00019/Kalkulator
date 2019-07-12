using System;

namespace Calculator
{
    public class Degree : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the square of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// square
        /// </returns>
        public double Calculate(double one)
        {
            return Math.Pow(one, 2);
        }
    }
}
