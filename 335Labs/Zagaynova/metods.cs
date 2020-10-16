using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace _335Labs.Zagaynova
{
    class metods
    {
        public static void Division(double a, int b, int c)
        {
            double result = 0;
            for (int i = b; i <= c; i++)

            {
                if (i == 0) { Console.WriteLine("Cannot be divided by zero"); i = i + 1; };
                result = a / i;
                Console.WriteLine(result);

            }

        }

        public static (double, double) Sqrtroot(double a, double b, double c)
        {
            double diskrim = b * b - 4 * a * c;
            double x1 = ((-b + Math.Sqrt(diskrim) / 2));
            double x2 = ((-b - Math.Sqrt(diskrim) / 2));
            if (diskrim < 0)
            {
                Console.WriteLine("no roots");
                return (0, 0);
            }
            return (x1, x2);

         }
        public static double Pifagor ( double a,double b )
        {
            double result = Math.Sqrt(a * a + b * b);

            return result;

        }

        public static double Circumference(double r)
        {
            double result = 2 * 3.14 * r;
            return result;
        }
        public static double AreaCircle(double r)
        {
            double result = 3.14 * r * r;
            return result;
        }












    }
}

