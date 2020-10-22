using System;

namespace _335Labs
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1) Area of a circle
            Console.WriteLine("--------------Площадь круга---------------");
            Console.WriteLine("Введите радиус круга: ");
            double r = double.Parse(Console.ReadLine());
            double res = Kirillov.class_1.Area_of_a_circle(r);
            Console.WriteLine($"S круга равна: ");
            Console.WriteLine(res);


            // 2) Circum Ference
            Console.WriteLine("--------------Периметр круга---------------");
            Console.WriteLine("Введите радиус круга: ");
            double r2 = double.Parse(Console.ReadLine());

            double res2 = Kirillov.class_1.Circum_ference(r2);
            Console.WriteLine($"Периметр круга: ");
            Console.WriteLine(res2);


            // 3) Parallelepiped's Volume
            Console.WriteLine("-------------Объем параллелепипеда--------------");
            Console.WriteLine("Введите площадь основания параллелепипеда: ");
            double sqrmain = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ее высоту: ");
            double h = double.Parse(Console.ReadLine());

            double res3 = Kirillov.class_1.Par_Volume(sqrmain, h);
            Console.WriteLine($"Объем параллелепипеда: ");
            Console.WriteLine(res3);


            // 4) Square function
            Console.WriteLine("-------------Квадратичная функция y=ax2+bx+c--------------");
            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("c = ");
            double c = double.Parse(Console.ReadLine());
            double res4 = Kirillov.class_1.Square_function(a, b, x, c);
            Console.WriteLine($"Функция y = ");
            Console.WriteLine(res4);


            // 5) Pythagorean theorem
            Console.WriteLine("-------------Теорема Пифагора--------------");
            Console.WriteLine("a = ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            double b1 = double.Parse(Console.ReadLine());
            double res5 = Kirillov.class_1.Pifagor_T(a, b);
            Console.WriteLine($"Величина 'c' = ");
            Console.WriteLine(res5);
        }
    }
}
