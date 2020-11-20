using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova
{
    class metods
    {
        static void division(double a, int b, int c)
        {
            double result = 0;
            for (int i = b; i <= c; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Cannot be divided by null");
                    i = i + 1;
                }
                result = a / i;
                Console.WriteLine(result);
            }
        }
        static int FindRoot(int a, int b, int c, int x)
        {
            int result = a * (x * x) - (b * x) + c;
            return result;
        }
        static double Pyth(int a, int b)
        {
            double result = Math.Sqrt(a * a + b * b);
            return result;

        }
        static double Circumference(int r)
        {
            double result = Math.PI * 2 * r;
            return result;

        }
        static double AreeCirc(int r)
        {
            double result = Math.PI * r * r;
            return result;

        }
        static int VolParall(int a, int b, int h)
        {
            int result = a * b * h;
            return result;

        }
        static double CurrentCount(int i, int r, int u)
        {
            if (i == 0)
            {
                i = u / r;
                return i;

            }
            else if (r == 0)
            {
                r = u / i;

            }
            else if (u == 0)
            {
                u = i * r;
                return u;
            }
            return u;
        }

    }
}

