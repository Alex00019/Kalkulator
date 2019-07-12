using System;

namespace Calculator
{
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// finding the maximum element
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// maximum element
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Max(first, second);
        }
    }
}