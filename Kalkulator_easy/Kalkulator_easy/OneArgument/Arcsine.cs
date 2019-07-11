using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Arcsine : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            if (argument > 1 || argument < -1) throw new Exception(" Значение недопустимо ");
            return Math.Asin(argument);
        }
    }
}
