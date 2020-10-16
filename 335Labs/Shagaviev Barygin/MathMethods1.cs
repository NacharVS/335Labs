using _335Labs;
using System;


namespace _335Labs.Shagaviev_Barygin
{
    class MathMethods1
    {
        public static void Discriminant()
        {
            double a, b, c;
            Console.WriteLine("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c= ");
            c = Convert.ToDouble(Console.ReadLine());
            Reshenie myclass = new Reshenie(a, b, c);
        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public Reshenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void rashet()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1={0}\n x2={1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Корней нет");
                Console.ReadKey();
            }
        }
    }
}

