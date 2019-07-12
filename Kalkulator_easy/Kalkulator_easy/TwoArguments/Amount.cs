namespace Calculator
{
    public class Amount : ITwoArgumentsCalculator
    {
        /// <summary>
        /// perform addition of the first argument and the second argument
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// adding arguments 
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
