namespace Calculator
{
    class Amount : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
