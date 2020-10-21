using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev
{
    class Strings
    {

        public static string Checht(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {

                    Console.Write(s[i] + "     ");
                }
                else if (i % 2 != 0)
                    Console.WriteLine(s[i] + "");

            }


            return "";
        }
        public static string RD(string s)
        {
                string even = null;
                string odd = null;
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0)
                        even += s[i];
                    else
                        odd += s[i];

                }
                Console.WriteLine(even);
                Console.WriteLine(odd);
            return "";

        }
        
        public static string Paralendrom(string s)
        {
            string res = null;
            s = s.Replace("", "").ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                res += s[s.Length - 1 - i];
            }
            Console.WriteLine(res);
            if (s==res)
                Console.WriteLine("+");
            else
                Console.WriteLine("-");
            return "";

        }
        public static void TheSame(string s)
        {
            string news = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (news.Contains(s[i]))
                    continue;
                else news += s[i];
                Console.WriteLine(news);
                
            }
            

        }


    }



    
}
