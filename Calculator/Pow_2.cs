using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Pow : BinaryOperation
    {
        public override double bbbbbb(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
