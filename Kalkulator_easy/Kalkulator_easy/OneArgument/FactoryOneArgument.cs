﻿using System;

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
                case "tan":
                    return new Tangent();
                case "arcsine":
                    return new Arcsine();
                case "arctan":
                    return new Arctan();
                case "oneDivideByX":
                    return new OneDivideByX();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

