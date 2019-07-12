using System;

namespace Calculator
{
    public class Min : ITwoArgumentsCalculator
    {
        /// <summary>
        /// finding the minimum element
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// minimum element
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}
