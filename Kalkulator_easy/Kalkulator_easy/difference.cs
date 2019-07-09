using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_easy
{
    class difference : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {

            return first - second;
        }
    }
}
