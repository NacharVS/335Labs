    using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev
{
    class Methods
    {
        public static int DivofInt(int a, int b, int c)
        {
            int res = 0;
            for (int i = a; i <= b; i++)
            {
                if (i == 0)

                {
                    continue;

                }
                res = c / i;
                Console.WriteLine(res);
            }
            return 0;


        }
        public static (double, double) xx(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {

                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                return (x1, x2);
            }
            else Console.WriteLine("korney net");
            return (0, 0);
        }
    
            

        
        public static double Pif(double a, double b)
        {
            double d = a * a + b * b;
            double c = Math.Sqrt(d);
            return c;
        }
        public static double Circum(double r)
        {
            double c = 2 * 3.14 * r;

            
            return c;
        }
        public static double CirArea(double r)
        {
            double c = 3.14 * r * r;

            ;
            return c;
            
        }
        public static double ParVol(double a, double b, double c)
        {
            double res = a * b * c;

            return res;
        }
        public static double AVR(double a, double b)
        {
            double i = a / b;
            return i;
        
        
        }
        public static double RVA(double a, double b)
        {
            double r = a / b;
            return r;
        }
        public static double VRA(double a, double b)
        {
            double v=a*b;
            return v;
        }










    }
}
