using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Tangens: Operation
    {
        public override double Calculate(double x)
        {
            return Math.Round(Math.Tan(x*3.14/180));
        }
    }
}
