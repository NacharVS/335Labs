using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov
{
    class Methotds
    {
        public static int Sum(int a, int b, int c)

        {
            int res = 0;
            for (int i = a; i <= b; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                res = c / i;
                Console.WriteLine(res);
            }
            return res;
        }
        public static (double, double) Disc(double a, double b, double c)
        { 
            double D = b * b - 4 * a * c;
          
            if (D>=0)
            {
             double x1 = (-b + Math.Sqrt(D)) / (2 * a);
             double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return (x1, x2);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
            return (1,1); 
        }
    }
}

