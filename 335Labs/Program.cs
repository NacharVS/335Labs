using System;
using System.Linq;

namespace _335Labs.Faizrakhmanov.Delegates
{
    namespace DelgateForNotes
    {
        class Program
        {
            public delegate int AddDelegate(int[] mas);

            static void Main(string[] args)
            {
                int[] mas = new int[] { 1, 2, 3, 4, 5 };
                AddDelegate one = new AddDelegate(Sum);
                int a = one(mas);
                Console.WriteLine("Сумма ", a);
               
                Console.Read();
            }

            public static int Sum(int[] mas)
            {
                int sumation;
                sumation = mas.Sum();
                return sumation;
            }
            
        }
    }
}