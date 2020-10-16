using _335Labs;
using System;


namespace _335Labs.Shagaviev_Barygin
{
    class MathMethods1
    {
        public static void CirculFerence()
        {
            double r, p, l;
            Console.WriteLine("Ведите Радиус");
            r = Convert.ToDouble(Console.ReadLine());
            p = 3.14;
            l = r * p * 2;
            Console.WriteLine("Length = {0}", l);
            Console.ReadKey();
        }
    }
}

