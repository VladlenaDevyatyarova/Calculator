using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Acos : Operation
    {
        public override double Calculate(double x)
        {
            return Math.Acos(x);
        }
    }
}
