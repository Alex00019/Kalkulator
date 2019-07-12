using System;

namespace Calculator
{
    public class Catangent : IOneArgumentsCalculator
    {
        /// <summary>
        /// finding the catangenth of the argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// catangenth of the argument
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Tan(1 / argument);
        }
    }
}
