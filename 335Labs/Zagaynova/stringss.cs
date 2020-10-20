using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class @Stringss
    {
        public static void Raspr(string s)

        {
            string  Even = null;
            string Odd = null;


            for (int i = 0; i < s.Length; i++)
                
            { int d = i % 2;

                if (d == 0)
                {
                    Even += s[i];
                }

                else if (d!= 0)
                {
                    Odd += s[i]; 
                    
                }
             }
            Console.WriteLine(Even);
            Console.WriteLine(Odd);

         }


        public static void Del(string s)
        {
           

            for (int i = 0; i < s.Length; i++)


            {
                for (int j= 0; j < s.Length; j++)
                { 
                    if (s[i]==s[j]) { s.Remove(s[i],1); }
                }

            }
            Console.WriteLine(s);
        }
    























    }
}
