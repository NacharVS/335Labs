using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova
{
    class @string


    {
        public static void Odd_Even(string s)
        {

            Console.WriteLine("Odd characters");
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') continue;
                if (i%2==0)
                    Console.WriteLine(s[i]);
            }
            Console.WriteLine();


            Console.WriteLine("Even charakters");
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') continue;

                if (i % 2 ! = 0)
                    Console.WriteLine(s[i]);
            }

        }


        public static void countwords (string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Count of words per line = { words.Length}");

        }


        public static void Palindrome(string s)
        {

            s = s.Replace(" ", "");
            int count = 0;
            for (int i =0; i <s.Length; i++)
            {
                if (s[i] == s[s.Length - 1 - i])
                    count += 1;

            }
            if (count == s.Length)
                Console.WriteLine("This string is a palendrome");
            else
                Console.WriteLine("This string is not a palendrome");
        }

    }

   

}
