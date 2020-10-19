using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov
{
    class @strings1
    {
       public static string First(string a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {

                    Console.Write(a[i] + "        ");
                }
                else if (i % 2 != 0)
                    Console.WriteLine(a[i]);

            }
            return " ";
        }

        public static string Second(string a)
        {
            
        }

    }
}
