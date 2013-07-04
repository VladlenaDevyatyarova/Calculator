using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Vichitanie:BinaryOperation
    {
        public override double Calculate(double x, double y)
        {
            return (x - y);
        }
    }
}
