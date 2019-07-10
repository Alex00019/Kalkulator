using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OneDivideByX : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / argument;
        }
    }
}
