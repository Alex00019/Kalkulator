using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_easy
{
    public class Factory_2
    {
        public static Interface777 Calculate(string name)
        {
            switch (name)
            {
                case "Root":
                    return new Root();
                case "Degree":
                    return new Degree();
                
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

    }
}

