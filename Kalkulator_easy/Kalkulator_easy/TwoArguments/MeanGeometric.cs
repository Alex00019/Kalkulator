using System;

namespace Calculator
{
    public class MeanGeometric : ITwoArgumentsCalculator
    {
        /// <summary>
        /// finding the geometric mean
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// geometric mean
        /// </returns>
        public double Calculate(double first, double second)
        {
            return Math.Sqrt((first*first) + (second*second));
        }
    }
}
