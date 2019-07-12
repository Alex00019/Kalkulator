using System;

namespace Calculator
{

    public class FactoryTwoArguments
    { /// <summary>
      /// This method create calculator with two arguments
      /// </summary>
      /// <param name="name">
      /// Calling name 
      /// </param>
      /// <returns>
      /// It`s calculator
      /// </returns>
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
                case "degreeTwo":
                    return new DegreeTwoArguments();
                case "logXAcrossY":
                    return new LogOneByTwo();
                case "remainderOfDivision":
                    return new RemainderOfDivisio();
                case "min":
                    return new Min();
                case "arifmeticMean":
                    return new ArifmeticMean();
                case "reversePower":
                    return new ReversePower();
                case "max":
                    return new Max();
                case "meanGeometric":
                    return new MeanGeometric();
                    default:
                    throw new Exception("Неизвестная операция");
            }
        }    
     }
}
