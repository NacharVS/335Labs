using System;

namespace _335Labs
{
    class Program
    {
        static void FindRoot(int a, int b, int c, int x)
        {
            // ax^2-bx+c
            int result = a * (x * x) - (b * x) + c;
            Console.WriteLine(result);
        }

        static void Pyth(int a, int b)
        {
            //c^2=a^2+b^2
            double result = Math.Sqrt(a * a + b * b);
            Console.WriteLine(result);
        }

        static void Circumference(int r)
        {
            // Circumference
            double result = Math.PI * 2 * r;
            Console.WriteLine(result);
        }

        static void AreaCirc(int r)
        {
            // Circle's area
            double result = Math.PI * r * r;
            Console.WriteLine(result);
        }

        static void VolParall(int a, int b, int h)
        {
            //Parallelepiped's area
            int result = a * b * h;
            Console.WriteLine(result);

        }

        static void CurrentCount(int i, int r, int u)
        {
            // amperage/voltage/resistance (PROBABLY NEEDS REWORK)
            if (i == 0)
            {
                i = u / r;
                Console.WriteLine(i);
            }
            else if (r == 0)
            {
                r = u / i;
                Console.WriteLine(r);
            }
            else
            {
                u = i * r;
                Console.WriteLine(u);
            }
        }

        static void Division(double a, int b, int c)
        {
            // Finds result of division number by an interval of numbers
            double result;
            for (int i=b; i<=c; i++)
            {
                if (i==0)
                {
                    Console.WriteLine("Can't divide by 0");
                    i++;
                }
                result = a / i;
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            // Testing

            // ax^2-bx+c
            // FindRoot(1, 2, 3, 4);


            //c^2=a^2+b^2
            // Pyth(20, 30);
        

            // Circumference
            // Circumference(5);


            // Circle's area
            // AreaCirc(5);
    

            // Parallelepiped's area
            // VolParall(2, 3, 2);
            

            // amperage/voltage/resistance
            // CurrentCount(0, 5, 15);
            

            // Finds result of division number by an interval of numbers
            // Division(15, 1,15);
            Console.ReadLine();

        }
    }
}
