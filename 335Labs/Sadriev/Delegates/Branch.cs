using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _335Labs.Sadriev.Delegates
{
    class Branchs
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
                Console.WriteLine(array[i]);
            }
        }
        public static void Max(int[] array)
        {
            int max = array.Max();
            Console.WriteLine(max);

        }
        public static void Sum(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine(sum);
        }
        public static void DuoSum(int[] array1, int[] array2)
        {

            int[] sumdva = new int[5];
            for (int i = 0; i < sumdva.Length; i++)
            {
                int sd = array1[i] + array2[i];
                Console.Write("/n" + sd);
            }

        }
        public static void SubDva(int[] array1, int[] array2)
        {

            int[] sumdva = new int[5];
            for (int i = 0; i < sumdva.Length; i++)
            {
                int sd = array1[i] - array2[i];
                Console.Write("/n"+sd);
            }

        }
        public static void ComDva(int[] array1, int[] array2)
        {

            int[] mult= new int[array1.Length];
            for (int i = 0; i < mult.Length; i++)
            {
                int cd = array1[i] * array2[i];
                Console.Write("/n"+cd);
            }

        }
    }

}
