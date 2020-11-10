using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Agafetov
{
    class delegates
    {
       public static void First(int[] array)
        {
            int kol = 0, g = 0, i;
            Console.Write("введите размерность массива: ");
            int m = Convert.ToInt16(Console.ReadLine());
            int[] mas = new int[m];

            for (i = 0; i < m; i++)
            {
                mas[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("Выберите и введите число с массива: ");
            int x = Convert.ToInt16(Console.ReadLine());

            for (i = 0; i < m; i++)
            {
                if (mas[i] == x)
                {
                    kol = mas.Length - i;
                    g = i;
                    break;
                }

            }

            int[] mas2 = new int[kol];

            for (g = i; g < mas2.Length; g++)
            {
                mas2[g] = mas[g];

            }
            for (int f = 0; f < mas2.Length; f++)
            {
                Console.WriteLine(mas2[f]);

            }

            Console.ReadKey();
        }

    }
}
       
