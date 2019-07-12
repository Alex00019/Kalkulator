using System;

namespace Calculator
{
    public class DegreeTwoArguments : ITwoArgumentsCalculator
    {
        /// <summary>
        /// exponentiation
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// exponentiation of the first number second number
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
