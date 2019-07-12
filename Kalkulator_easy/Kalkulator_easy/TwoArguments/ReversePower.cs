using System;

namespace Calculator
{
    public class ReversePower : ITwoArgumentsCalculator
    {
        /// <summary>
        /// exponentiation 
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// revers second value
        /// </param>
        /// <returns>
        /// exponentiation of the revers first number second number
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1 / second);
        }
    }
}