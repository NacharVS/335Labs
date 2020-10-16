using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class MathMethods2
    {
        public static void Discriminant()
        {

            double a, b, c, d;
            Console.Write("Введите значение a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение c = ");
            c = Convert.ToDouble(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.Write("Дискриминант d < 0<. Решение квадратного уравнения невозможно.");
            }
            else
            {

                double x1, x2;

                if (d == 0)
                {
                    x1 = x2 = -(b / 2 * a);
                }
                else
                {

                    float sqrtD = (float)System.Math.Sqrt(d);

                    x1 = (-b + sqrtD) / (2 * a);
                    x2 = (-b - sqrtD) / (2 * a);
                }

                Console.Write("d = " + d.ToString() + " x1 = " + x1.ToString() + " x2 = " + x2.ToString());
            }

            Console.ReadLine();
        }
    }
}