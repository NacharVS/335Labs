using System;

namespace _335Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Area of a circle
            Console.WriteLine("Введите радиус круга: ");
            double r = double.Parse(Console.ReadLine());

            double res = Kirillov.Area_of_a_circle1.Area_of_a_circle(r);
            Console.WriteLine($"S круга равна: ");
            Console.WriteLine(res);
            Console.WriteLine(" ");

            // 2) Circum Ference
            Console.WriteLine("Введите радиус круга: ");
            double r2 = double.Parse(Console.ReadLine());

            double res2 = Kirillov.Circum_ference1.Circum_ference(r);
            Console.WriteLine($"Периметр круга: ");
            Console.WriteLine(res);
        }
    }
}
