using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Bubble : StringOperation
    {
        public override int[] Calculate(int[] StringInt)
        {
            int temp = 0;
            for (int i = 0; i < StringInt.Length - 1; i++)
            {
                for (int j = i + 1; j < StringInt.Length; j++)
                {
                    if (StringInt[i] > StringInt[j])
                    {
                        temp = StringInt[i];
                        StringInt[i] = StringInt[j];
                        StringInt[j] = temp;
                    }
                }
            }
            return StringInt;
        }
    }
}

