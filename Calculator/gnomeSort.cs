using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class gnomeSort : StringOperation
    {
        public override int[] Calculate(int[] StringInt)
        {
            int i = 1;
            int j = 2;

            while (i < StringInt.Length)
            {
                if (StringInt[i - 1] <= StringInt[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int tmp = StringInt[i - 1];
                    StringInt[i - 1] = StringInt[i];
                    StringInt[i] = tmp;
                    i -= 1;
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }

            return StringInt;
        }
    }
}
