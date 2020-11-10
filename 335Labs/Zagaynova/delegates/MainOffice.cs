using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _335Labs.Zagaynova.delegates
{
    class MainOffice
    {
        public static void Sorting(int[] mas)

        {
            Array.Sort(mas);
            Console.Write("sort:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] +  " ");
            }
        }
        public static void Max(int[] mas)
        {
            int max = mas.Max();
            Console.WriteLine( "max:"+  max);

        }
        public static void Summa (int []mas)
        {
            int sum = mas.Sum();
            Console.WriteLine("sum:" , sum);
        }
        public static void SummaDva(int[] masOne, int[] masTwo)
        {
            Console.Write("SumDva:");

            
            for (int i = 0; i < masOne.Length; i++)
            {
              int n = masOne[i] + masTwo[i];
                Console.Write(n+ " ");
            }
            Console.WriteLine();

        }
        public static void SubDva(int[] masOne, int[] masTwo)
        {
            Console.Write("SubDva:");

           
            for (int i = 0; i < masOne.Length; i++)
            {
                int n = masOne[i] - masTwo[i];
                Console.Write(n + " ");
            }
            Console.WriteLine();

        }
        public static void ComDva(int[] masOne, int[] masTwo)
        {
            Console.Write("ComDva:");

          
            for (int i = 0; i < masOne.Length; i++)
            {
                int n = masOne[i] * masTwo[i];
                Console.Write(n + " ");
            }
            Console.WriteLine();

        } 
    } 
}
