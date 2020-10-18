using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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
        public static double Pif(double a, double b)
        {
            if (a > 0 & b >0)
            {
                double c = Math.Sqrt(a * a + b * b);
                Console.WriteLine(c);    
            }
            else
            {
                Console.WriteLine("отрезки не могут быть отрицательными!");
            }
            return 0;
        }

        public static double Circircumference(double r)
        {
            if (r > 0)
            {
                double C = 2 * 3.14 * r;
                Console.WriteLine($"Длина окружности = {C}");
            }
            else
            {
                Console.WriteLine("отрезки не могут быть отрицательными!");
            }
            return 0;
        }

        public static double AreaCir(double r)
        {
            if (r > 0)
            {
                double S = 3.14 * r * r;
                Console.WriteLine($"Площадь окружности = {S}");
            }
            else
            {
                Console.WriteLine("отрезки не могут быть отрицательными!");
            }
            return 0;

        }

        public static int Volume(int a, int b, int c)
        {
            if (a > 0 & b > 0 & c > 0)
            {
                int V = a * b * c;
                Console.WriteLine($"Объем параллелепипеда = {V}");
            }
            else
            {
                Console.WriteLine("отрезки не могут быть отрицательными!");
            }
            return 0;
        }

        public static int Amperage(int U, int R)
        {
            int I = U / R;
            Console.WriteLine($"I = {I}");
            return 0;
        }

        public static int Voltage(int I, int R)
        {
            int U = I * R;
            Console.WriteLine($"U = {U}");
            return 0;
        }

        public static int Resistance(int I, int U)
        {
            int R = U / I;
            Console.WriteLine($"R = {R}");
            return 0;
        }

    }
}

