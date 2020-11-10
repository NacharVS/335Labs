using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _335Labs.Sadriev.Delegates
{
    class General
    {
        //Метод для сортровки одномерного массива
        //Сумма элементов одномерного массива
        //Максимальное чилсо одномерного массива  массива
        //Сумма,разность,произвдение двух одномерных массивов по элементам

        

        public static void Sortby(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        int memory = array[i];
                        array[i] = array[j];
                        array[j] = memory;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Sorted: " + array[i]+"\n");
            }
        }
        public static void Max(int[] array)
        {
            int max = array.Max();
            Console.WriteLine("\t Max:" + max);

        }
        public static void Sum(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine("\t Sum:" + sum);
        }
        public static void DuoSum(int[] array1, int[] array2)
        {
            
            for (int i = 0; i < array1.Length; i++)
            {
                int sd = array1[i] + array2[i];
                Console.Write("\n" + sd);
            }

        }
        public static void DuoSub(int[] array1, int[] array2)
        {

            
            for (int i = 0; i < array1.Length; i++)
            {
                int sd = array1[i] - array2[i];
                Console.Write("\n"+sd);
            }

        }
        public static void DuoMult(int[] array1, int[] array2)
        {

            
            for (int i = 0; i < array1.Length; i++)
            {
                int cd = array1[i] * array2[i];
                Console.Write("\n"+cd);
            }

        }
    }

}
