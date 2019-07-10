using System;

namespace Calculator
{
    public class FactoryTwoArguments
    {
        public static ITwoArgumentsCalculator CreateCalculate(string name)
        {
            switch (name)
            {
                case "amount":
                    return new Amount();
                case "difference":
                    return new Difference();
                case "multiplication":
                    return new Multiplication();
                case "division":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }    
     }
}
