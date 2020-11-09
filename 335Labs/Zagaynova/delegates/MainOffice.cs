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
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
        public static void Max(int[] mas)
        {
            int max = mas.Max();
            Console.WriteLine(max);

        }
        public static void Summa (int []mas)
        {
            int sum = mas.Sum();
            Console.WriteLine(sum);
        }
        public static void SummaDva(int[] masOne, int[] masTwo)
        {

            int[] sumdva= new int [5];
            for (int i = 0; i < sumdva.Length; i++)
            {
              int n = masOne[i] + masTwo[i];
                Console.Write(n+ " ");
            }
            
        }
        public static void SubDva(int[] masOne, int[] masTwo)
        {

            int[] sumdva = new int[5];
            for (int i = 0; i < sumdva.Length; i++)
            {
                int n = masOne[i] - masTwo[i];
                Console.Write(n + " ");
            }

        }
        public static void ComDva(int[] masOne, int[] masTwo)
        {

            int[] sumdva = new int[5];
            for (int i = 0; i < sumdva.Length; i++)
            {
                int n = masOne[i] * masTwo[i];
                Console.Write(n + " ");
            }

        }
    } 
}
