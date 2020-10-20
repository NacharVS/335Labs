using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev
{
    class Strings
    {
      
        public static string  Checht(string s)
        {
            
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    
                    Console.Write(s[i] + "      ");
                }
                else if(i%2!=0)
                    Console.WriteLine(s[i]);

            }


            return "";
        }
        public static string RD(string s)
        {
            return new string(s.ToCharArray());
        }



    }
}
