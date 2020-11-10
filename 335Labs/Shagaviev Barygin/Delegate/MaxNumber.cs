using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _335Labs.Shagaviev_Barygin.Delegate
{
    class MaxNumber
    {
            public static void Num()
            {
                int[] ar = { 67, 34, 3, 8, 35, 23 };
                int maxValue = ar.Max<int>();
                Console.WriteLine(maxValue);
            }
        


    }
}

