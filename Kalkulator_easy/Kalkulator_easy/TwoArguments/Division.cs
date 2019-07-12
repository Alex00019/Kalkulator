using System;

namespace Calculator
{
    public class Division : ITwoArgumentsCalculator
    {
        /// <summary>
        /// division
        /// </summary>
        /// <param name="first">
        /// dividend
        /// </param>
        /// <param name="second">
        /// divider
        /// </param>
        /// <returns>
        /// divide the first number by three
        /// </returns>
        public double Calculate(double first, double second)
        {
            if (second == 0) throw new Exception(" Деление на ноль ");
            return first / second;

        }
    }
}