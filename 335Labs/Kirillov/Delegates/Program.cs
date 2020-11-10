using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _335Labs.Kirillov.Delegates
{
    namespace DelgateForNotes
    {
        class Program
        {
            public delegate int AddDelegate(int[] mas);

            static void Main(string[] args)
            {
                int[] mas = new int[] { 1, 2, 3, 4, 5 };
                AddDelegate del1 = new AddDelegate(Sum);
                AddDelegate del2 = new AddDelegate(Max);
                AddDelegate del3 = new AddDelegate(Sort);
                int a = del1(mas);
                int b = del2(mas);
                int d = del3(mas);
                Console.WriteLine("Сумма = {0}", a);
                Console.WriteLine("Макс. число = {0}", b);
                Console.WriteLine("Сортировка массива = {0}", d);
                Console.Read();
            }

            public static int Sum(int[] mas)
            { 
                int sumation;
                sumation = mas.Sum();
                return sumation;
            }
            public static int Max(int[] mas)
            {
                int sumation;
                sumation = mas.Max();
                return sumation;

            }
            public static int Sort(int[] mas)
            {
                Array.Sort(mas);
                for (int i = 0; i < mas.Length; i++)
                {
                    return mas[i];

                }
                
            }
        }
    }
}
