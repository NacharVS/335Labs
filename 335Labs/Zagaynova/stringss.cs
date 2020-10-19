using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class @stringss
    {
        public static (string,string) Raspr( string s)
        {
            string Even = null;
            string Odd = null;
            for (int i = 0; i <=s.Length ; i++)
                
            { int d = i % 2;

                if
                 (d == 0) { Even = Even + s[i]; }

                else { Odd += +s[i]; }
             }
            return (Even, Odd);
           

       

        }


























    }
}
