using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Fabric
    {
        public static BinaryOperation Calc(string calculatorName)
        {
            switch (calculatorName)
            {
                case "+": return new Addition();
                case "-": return new Vichitanie();
                case "*": return new Umnogenie();
                case "/": return new Delenie();
                case "x^y": return new Pow();

                default: throw new Exception("Неизвестная операция");
            }
            
        }
        
    }
}
