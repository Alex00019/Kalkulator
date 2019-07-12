using System;

namespace Calculator
{
    public class FactoryOneArgument
    {
        /// <summary>
        /// This method create calculator with one argument
        /// </summary>
        /// <param name="name">
        /// Calling name 
        /// </param>
        /// <returns>
        /// It`s calculator
        /// </returns>
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
                case "tan":
                    return new Tangent();
                case "arcsine":
                    return new Arcsine();
                case "arctan":
                    return new Arctan();
                case "oneDivideByX":
                    return new OneDivideByX();
                case "cose":
                    return new Cos();
                case "exp":
                    return new Exp();
                case "arccose":
                    return new Arcos();
                case "arcctg":
                    return new Arcctg();
                case "catangent":
                    return new Catangent();
                case "logarithmTen":
                    return new LogarithmTen();
                case "twoDivide":
                    return new TwoDivideX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

