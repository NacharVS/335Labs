using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _335Labs.Gilmutdinov.Deligatedd
{
    class Secondary
    {
        public static void First(int[] array)
        {
            int temp;
            for (int x = 0; x < array.Length-1; x++)
            {
                for (int j = x + 1; j < array.Length; j++)
                {
                    if (array[x] > array[j])
                    {
                        temp = array[x];
                        array[x] = array[j];
                        array[j] = temp;
                    }
                }
             
            }
                for (int x = 0; x < array.Length; x++)
                {
                    Console.WriteLine(array[x]);
                }
        }
    }

        public static void Sum(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine(sum);
        }


}
