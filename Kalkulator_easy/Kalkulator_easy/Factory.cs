using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_easy
{
    public class Factory
    {
        public static ITwoArgumentsCalculator Calculate(string name)
        {
            switch (name)
            {
                case "amount":
                    return new amount();
                case "difference":
                    return new difference();
                case "multiplication":
                    return new multiplication();
                case "division":
                    return new division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    
            }
}
