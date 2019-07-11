using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class LogOneByTwo : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if ((second <= 0) || (first < 0) || (first == 1) ) throw new Exception(" Значение логарифма недопустимо ");
            return Math.Log(first, second);
        }
    }
}
