using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _335Labs.GirfanovaBakhmutova
{
    public static class General
    {
        //int sum = 0;
        //sum += mas[i];
        //mas[i] = mas[i] / sum;

        //сумма одномерного массива
        //public delegate void General1();
        //int[] mas;

        public delegate void MathOneArray(Array val);
        public static void Sort(Array val) 
        {
            Array.Sort(val);
            Console.WriteLine(val);
        }

        public static int Summary(int[] val) 
        {
            int sum = 0;
            foreach (int value in val)
                sum += value;
            return sum; 
        }

        private static void MaxValue(int[] val)
        {
            int Maximum = val.Max();
        }

        public delegate void MathTwoArrays(int[] Arr1, int[] Arr2);

        public static void ArraysSum(int[] Arr1, int[] Arr2)
        {
            int[] Arr3 = new int[0];
            for (int r = 0; r < Arr1.Length; ++r)
            {
                Arr3 [r] = Arr1[r] + Arr2[r];
            }
        }

        public static void ArraysSub(int[] Arr1, int[] Arr2)
        {
            int[] Arr3 = new int [0];
            for (int r = 0; r < Arr1.Length; ++r)
            {
                Arr3[r] = Arr1[r] - Arr2[r];
            }
        }

        public static void ArraysMult(int[] Arr1, int[] Arr2)
        {
            int[] Arr3 = new int[0];
            for (int r = 0; r < Arr1.Length; ++r)
            {
                Arr3[r] = Arr1[r] * Arr2[r];
            }
        }
    }
}
