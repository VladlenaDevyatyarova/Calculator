using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Sinus:Operation
    {
        public override double Calculate(double x)
        {
            return Math.Sin(x);
        }
    }
}
