using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class MonoFabric
    {
        public static operation Calc(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin": return new Sinus();
                case "cos": return new Cosinus();
                case "tg": return new Tangens();
                case "ctg": return new Cotangens();
                case "ln10": return new Log10();
                case "ln": return new Ln();
                case "sqrt": return new Sqrt();
                case "asin": return new Asin();
                case "acos": return new Acos();
                case "atg": return new Atg();
            }
        }
    }
}
