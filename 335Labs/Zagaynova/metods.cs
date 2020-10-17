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
        public static int ParallV(int a, int b, int c)
        {
            int result = a * b * c;
            return result;
        }

        public static void Fisika()
        {
            Console.WriteLine("What to find");
            Console.WriteLine("1-Voltage");
            Console.WriteLine("2-Amperage");
            Console.WriteLine("3-Resistance");
            int otvet = int.Parse(Console.ReadLine());
            if (otvet == 1)

            {
                Console.WriteLine("Enter Amperage and Resistance");
                double A = double.Parse(Console.ReadLine());
                double R = double.Parse(Console.ReadLine());
                double result = A * R;
                Console.WriteLine($"Voltage={result}");
            }
            if (otvet == 2)

            {
                Console.WriteLine("Enter Voltage and Resistance");
                double V = double.Parse(Console.ReadLine());
                double R = double.Parse(Console.ReadLine());
                double result = V / R;
                Console.WriteLine($"Amperage={result}");
            }
            if (otvet == 3)
            {
                Console.WriteLine("Enter Voltage and Amperage");
                double V = double.Parse(Console.ReadLine());
                double A = double.Parse(Console.ReadLine());
                double result = V / A;
                Console.WriteLine($"Amperage={result}");
            }
        }
    }
}

