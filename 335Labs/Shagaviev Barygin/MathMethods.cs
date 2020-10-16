using _335Labs;
using System;

namespace _335Labs.Shagaviev_Barygin
{
    class MathMethods
    {
        public static void Pythagore()
        {
            Console.WriteLine("введите число N");
            string st = Console.ReadLine();
            int N = int.Parse(st);

            for (int a = 1; a < N; a++)
            {
                for (int b = 1; b < N; b++)
                {
                    for (int c = 0; c < N; c++)
                    {
                        if ((a * a + b * b) == (c * c))
                            Console.WriteLine("a = " + a + ", b = " + b + ", c= " + c);

                    }
                }

            }
            Console.ReadLine();
        }
    }
}
