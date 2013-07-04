using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Log10 : Operation
    {
        public override double Calculate(double x)
        {
            return Math.Log10(x);
        }
    }
}
