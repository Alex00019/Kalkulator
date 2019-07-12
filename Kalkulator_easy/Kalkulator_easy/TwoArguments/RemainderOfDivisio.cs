namespace Calculator
{
    public class RemainderOfDivisio : ITwoArgumentsCalculator
    {
        /// <summary>
        /// finding the remainder of the division
        /// </summary>
        /// <param name="first">
        /// dividend
        /// </param>
        /// <param name="second">
        /// divider
        /// </param>
        /// <returns>
        /// the remainder of the division 
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
