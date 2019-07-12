namespace Calculator
{
    public class ArifmeticMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// finding the arifmetic mean
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// adding arguments and division into two
        /// </returns>
        public double Calculate(double first, double second)
        {
            return (first + second) / 2;
        }
    }
}
