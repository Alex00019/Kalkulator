using System;

namespace Calculator
{
    public class Arcos : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the arc cosine of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// arc cosine of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument > 1 || argument < -1)
            {
                throw new Exception(" Значение недопустимо ");
            }
            return Math.Acos(argument);
        }
    }
}
