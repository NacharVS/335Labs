using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _335Labs.Girfanova
{
    public static class General
    {

        public delegate void MathOA(int[] arr);
        public delegate void MathTA(int[] arr1, int[] arr2);

        public static void SortOA(Array arr)
        {
            Array.Sort(arr);
            Console.WriteLine(arr);
        }

        public static void SumOA(int[] arr)
        {
            int sum = 0;
            foreach (int value in arr)
            {
                sum += value;
            }
            Console.WriteLine(sum);
        }

        public static void FindMaxOA(int[] arr)
        {
            Array.Sort(arr);
            int max = arr[arr.Length - 1];
            Console.WriteLine(max);
        }

        public static void SumTA(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[0];
            for (int r = 0; r < arr1.Length; ++r)
            {
                arr3[r] = arr1[r] + arr2[r];
            }
            Console.WriteLine(arr3);
        }

        public static void SubTA(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[0];
            for (int r=0; r<arr1.Length; ++r)
            {
                arr3[r] = arr1[r] - arr2[r];
            }
            Console.WriteLine(arr3);
        }

        public static void MulTA(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[0];
            for (int r = 0; r < arr1.Length; ++r)
            {
                arr3[r] = arr1[r] * arr2[r];
            }
            Console.WriteLine(arr3);
        }

    }
}
