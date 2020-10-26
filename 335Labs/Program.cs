using _335Labs.Sadriev;
using System;

namespace _335Labs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BankAccount polz = new BankAccount();

            string ss = polz.Regist("Alena", "Alinovna");
             
            polz.PaymentAc(200000, "+");
            polz.PaymentAc(10000, "-");
            string gg = polz.Info(ss);
            Console.WriteLine(gg);
            ss = polz.Rename("Alina", "Alenovna");
            gg = polz.Info(ss);
            Console.WriteLine(gg);




















            //string s = "I don`t understand";
            //Console.WriteLine((Strings.Checht(s)));
            //Console.WriteLine(Strings.RD(s));
            //Console.WriteLine(Strings.Paralendrom(s));
            //Console.WriteLine(Strings.TheSame(s));





            //Console.WriteLine(Methods.DivofInt(-5, 5, 10));
            //Console.WriteLine(  );
            //Console.WriteLine(Methods.xx(1, 5, 4));
            //Console.WriteLine();
            //Console.WriteLine(Methods.Pif(4, 3));
            //Console.WriteLine();
            //Console.WriteLine(Methods.Circum(5));
            //Console.WriteLine();
            //Console.WriteLine(Methods.CirArea(3));
            //Console.WriteLine();
            //Console.WriteLine(Methods.ParVol(3, 5));
            //Console.WriteLine();
            //Console.WriteLine(Methods.AVR(200,5));
            //Console.WriteLine(Methods.RVA(200, 5));
            //Console.WriteLine(Methods.VRA(40,5));

        }
}
    }
