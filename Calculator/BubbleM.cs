using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;
namespace Calculator
{
    public class BubbleM : StringOperation
    {
        public override int[] Calculate(int[] StringInt)
        {
            int temp = 0, k=0;
            for (int i = 0; i < StringInt.Length; i++)
            {
                for (int j = i; j < StringInt.Length; j++)
                {
                    if (temp < StringInt[j])
                    { k = j; temp = StringInt[j]; }
                }
                temp = StringInt[i];
                StringInt[i] = StringInt[k];
                StringInt[k] = temp;
                temp = 0;
            }

            return StringInt;
        }
    }
}
