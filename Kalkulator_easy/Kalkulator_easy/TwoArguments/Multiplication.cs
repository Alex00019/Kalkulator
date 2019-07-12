namespace Calculator
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Multiplying numbers
        /// </summary>
        /// <param name="first">
        /// first value
        /// </param>
        /// <param name="second">
        /// second value
        /// </param>
        /// <returns>
        /// Multiplying 
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
