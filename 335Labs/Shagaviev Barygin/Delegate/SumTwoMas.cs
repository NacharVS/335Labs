using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _335Labs.Shagaviev_Barygin.Delegate
{
    class SumTwoMas
    {
        public static void STM()
        {
            int[] a = new int[5];
            Random rnd1 = new Random();

            int[] b = new int[5];
            Random rnd2 = new Random();
            for (int i = 0; i < a.Length; i++)

            {
                a[i] = rnd1.Next(1, 100);

            }
            Console.WriteLine(" ", a);

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd2.Next(1, 100);

            }
            Console.WriteLine(" ", b);
            int[] c = a.Select((element, index) => (element + b[index])).ToArray();
            Console.WriteLine(string.Join(" ", c));

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
