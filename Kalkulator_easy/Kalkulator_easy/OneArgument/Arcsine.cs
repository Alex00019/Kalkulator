using System;

namespace Calculator
{
    public class Arcsine : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the arc sine of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// arc sine of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument > 1 || argument < -1) throw new Exception(" Значение недопустимо ");
            return Math.Asin(argument);
        }
    }
}
