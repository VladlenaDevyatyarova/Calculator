using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class StringFabric
    {
        public static StringOperation StringSort(string calculatorName)
        {
            switch (calculatorName)
            {
                case "321": return new Puz();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
