using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Cotangens:Operation
    {
        public override double Calculate(double x)
        {
            return Math.Cos(x)/Math.Sin(x);
        }
    }
}
