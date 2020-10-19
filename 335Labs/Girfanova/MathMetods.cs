using System;

namespace _335Labs.Girfanova
{
    public class MathMetodsGirf
    {
        public static void FindRoot(int a, int b, int c, int x)
        {
            // ax^2-bx+c
            int result = a * (x * x) - (b * x) + c;
            Console.WriteLine(result);
        }

        public static void Pyth(int a, int b)
        {
            //c^2=a^2+b^2
            double result = Math.Sqrt(a * a + b * b);
            Console.WriteLine(result);
        }

        public static void Circumference(int r)
        {
            // Circumference
            double result = Math.PI * 2 * r;
            Console.WriteLine(result);
        }

        public static void AreaCirc(int r)
        {
            // Circle's area
            double result = Math.PI * r * r;
            Console.WriteLine(result);
        }

        public static void VolParall(int a, int b, int h)
        {
            //Parallelepiped's area
            int result = a * b * h;
            Console.WriteLine(result);

        }

        public static void CurrentCount(int i, int r, int u)
        {
            // amperage/voltage/resistance (PROBABLY NEEDS REWORK)
            if (i == 0)
            {
                i = u / r;
                Console.WriteLine(i);
            }
            else if (r == 0)
            {
                r = u / i;
                Console.WriteLine(r);
            }
            else
            {
                u = i * r;
                Console.WriteLine(u);
            }
        }

        public static void Division(double a, int b, int c)
        {
            // Finds result of division number by an interval of numbers
            double result;
            for (int i = b; i <= c; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Can't divide by 0");
                    i++;
                }
                result = a / i;
                Console.WriteLine(result);
            }
        }
    }
}
