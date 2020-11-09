using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Kirillov
{
    class class_1
    {
        static public double Area_of_a_circle(double r)
        {
            double pi = 3.1415;
            return pi * r * r;

        }
        static public double Circum_ference(double r2)
        {
            double pi = 3.1415;
            return 2 * pi * r2;

        }
        static public double Par_Volume(double sqrmain, double h)
        {
            return sqrmain * h;

        }

        static public double Square_function(double a, double x, double b, double c)
        {
            double y = a * x * x + b * x + c;
            if (a == 0)
            {
                Console.WriteLine("Коэффициэнт 'a' не должен равняться 0!");
                return 0;
            }
            else
            {
                return y;
            }

        }

        static public double Pifagor_T(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }


    }
}
