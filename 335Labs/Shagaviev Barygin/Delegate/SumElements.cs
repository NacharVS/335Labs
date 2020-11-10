using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _335Labs.Shagaviev_Barygin.Delegate
{
    class SumElements
    {
        public static void El()
        {
            int[] mas = new int[5];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 100);
                sum += mas[i];
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
