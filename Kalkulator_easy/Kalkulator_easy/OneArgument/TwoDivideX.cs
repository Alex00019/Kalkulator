using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TwoDivideX : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 2 / argument;
        }
    }
}
