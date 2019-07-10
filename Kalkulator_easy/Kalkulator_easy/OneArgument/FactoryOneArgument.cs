using System;

namespace Calculator
{
    public class FactoryOneArgument
    {
        public static IOneArgumentsCalculator CreateCalculate(string name)
        {
            switch (name)
            {
                case "Root":
                    return new Root();
                case "Degree":
                    return new Degree();
                case "sine":
                    return new Sine();
                    
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

