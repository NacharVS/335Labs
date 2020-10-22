using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class palindrom
    {
        public static void Slova()
        {
            string s = "Лёша на полке клопа нашёЛ";
            string res = null;
            s = s.Replace(" ", "").ToLower();
            for (int i=0; i < s.Length; i++)
            {
                res += s[s.Length - 1 - i];
            }
            if (s == res)
                Console.WriteLine("+");
            else
                Console.WriteLine("-");
        }
    }
}
