﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Cose : IOneArgumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}