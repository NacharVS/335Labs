using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova.Delegates
{
    class Branchoffice
    {
        private delegate void Array(string message);

        static void Main(string[] args)
        {
            int n, summa = 0;
            Random rnd = new Random();
            Console.WriteLine("find the dimension");
            _ = double.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(-10, 10);
                    Console.WriteLine(a[i, j] + "");
                    summa = summa + a[i, j];
                }

            }

        }
        private delegate void array1(string message);

        private static void Main1(string[] args)
        {
            int a, summa = 0;
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };


        }
    }
}



