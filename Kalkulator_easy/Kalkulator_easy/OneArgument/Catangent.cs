using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Catangent : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(1 / argument);
        }
    }
}
