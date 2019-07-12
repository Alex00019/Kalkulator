using System;

namespace Calculator
{
    public class LogOneByTwo : ITwoArgumentsCalculator
    {
        /// <summary>
        /// logarithm
        /// </summary>
        /// <param name="first">
        /// the base of the logarithm
        /// </param>
        /// <param name="second">
        /// the value of the logarithm
        /// </param>
        /// <returns>
        /// logarithm one by two arguments
        /// </returns>
        public double Calculate(double first, double second)
        {
            if ((second <= 0) || (first < 0) || (first == 1)) throw new Exception(" Значение логарифма недопустимо ");
            return Math.Log(first, second);
        }
    }
}
