namespace Calculator
{
    public class Difference : ITwoArgumentsCalculator
    {
        /// <summary>
        /// perform substraction from the first argument of the second argument
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// argument difference
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
