using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class chetnechet
    { 
         public static void Chisl()
        {
            string s = "Vestibul";
                string odd = null;
            string even = null;
            for (int i=0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    even += s[i];
                else odd += s[i];
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }

    }
}
