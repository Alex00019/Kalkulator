using System;

namespace Calculator
{
    public class Root: IOneArgumentsCalculator
    {
        /// <summary>
        /// root argument
        /// </summary>
        /// <param name="argument">
        /// value
        /// </param>
        /// <returns>
        /// <returns>
        /// root
        /// </returns>
        public double Calculate(double one)
        {
            return Math.Sqrt(one);
        }
    }
}
