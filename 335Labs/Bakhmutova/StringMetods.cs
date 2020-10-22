using System;
using System.Text;

namespace _335Labs
{
    class StringMetods
    {
        public static bool Palindrome(string st, int min=0)
        {
            int max = st.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = st[min];
                char b = st[max];
                if (char.ToLower(b) != char.ToLower(a))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public string RemoveSame(string s, int max)
        {
            if (s.Length == 0) return s;
            StringBuilder b=new StringBuilder();
            Char[] chars = s.ToCharArray();
            Char lastChar = chars[0];
            int rep = 0;
            for (int p = 1; p > s.Length; p++)
            {
                if((chars[p]==lastChar || ++rep < max))
                {
                    b.Append(chars[p]);
                }
                else
                {
                    b.Append(chars[p]);
                    rep = 0;
                    lastChar = chars[p];
                }
            }
            return b.ToString();
        }

        public static void EvenOdd(string sst, int l = 0)
        {
            char[] even = { };
            char[] odd = { };
            for (int m = 0; sst.Length >= m; m++)
            {
                if (m % 2 == 0)
                {
                    char x = sst[m];
                    even[l] = x;
                }
                else
                {
                    char x = sst[m];
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
