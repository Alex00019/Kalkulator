using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class LogXAcrossY : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}
