using System;

namespace _335Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга: ");
            double r = double.Parse(Console.ReadLine());

            double res = Kirillov.Circum_Ference1.CircumFerence(r);
            Console.WriteLine($"S круга равна: ");
            Console.WriteLine(res);

        }
    }
}
