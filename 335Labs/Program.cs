using System;

namespace _335Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            division(1, 5, 10);
        }
        static void division(double a, int b, int c)
        {
            double result = 0;
            for (int i = b; i < c; i++) 
            {
                result = a / i;
                Console.WriteLine(result);
            }
        }
        static void Discriminant(double a,int b,int c)
        {
            double result = 0;
            double x = 1;
            for (int i = b; i>a;i++)
            {
                result = a * x * x - b * x + c;

                Console.WriteLine(result);
            }
        }       
    }
}
