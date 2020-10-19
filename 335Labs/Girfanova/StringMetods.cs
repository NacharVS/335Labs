using System;

namespace _335Labs.Girfanova
{
    public static class StringMetodsGirf
    {
        public static bool Palindrome(string str)
        {
            // Palindrome
            int min = 0;
            int max = str.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = str[min];
                char b = str[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        public static void EvenOdd(string str)
        {
            int l = 0;
            char[] even = {};
            char[] odd = {};
            for (int m = 0; str.Length>=m; m++)
            {
                
                if (m % 2 == 0)
                {
                    char x = str[m];
                    even[l] = x;
                }

                else
                {
                    char x = str[m];
                    odd[l] = x;
                }
                l++;
            }
            for (int i = 0; i < even.Length; i++)
            {
                Console.WriteLine(even[i]);
            }
            for (int i = 0; i < odd.Length; i++)
            {
                Console.WriteLine(odd[i]);
            }
            Console.Read();
        }



    }
}
