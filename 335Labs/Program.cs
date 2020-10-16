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

            double res = Kirillov.class_1.Area_of_a_circle(r);
            Console.WriteLine($"S круга равна: ");
            Console.WriteLine(res);
            Console.WriteLine(" ");

            // 2) Circum Ference
            Console.WriteLine("Введите радиус круга: ");
            double r2 = double.Parse(Console.ReadLine());

            double res2 = Kirillov.class_1.Circum_ference(r2);
            Console.WriteLine($"Периметр круга: ");
            Console.WriteLine(res2);
            Console.WriteLine(" ");

            // 3) Parallelepiped's Volume
            Console.WriteLine("Введите площадь основания параллелепипеда: ");
            double sqrmain = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ее высоту: ");
            double h = double.Parse(Console.ReadLine());

            double res3 = Kirillov.class_1.Par_Volume(sqrmain, h);
            Console.WriteLine($"Объем параллелепипеда: ");
            Console.WriteLine(res3);
            Console.WriteLine(" ");


        }
    }
}
