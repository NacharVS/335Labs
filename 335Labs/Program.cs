using _335Labs.Gilmutdinov;
using System;

namespace _335Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Methotds.Sum(-5, 5, 10));
            //Console.WriteLine(Methotds.Disc(2, 10, -4));
            //Console.WriteLine(Methotds.Pif(2, 4));
            //Console.WriteLine(Methotds.Circircumference(2));
            //Console.WriteLine(Methotds.AreaCir(2));
            //Console.WriteLine(Methotds.Volume(5, 5, 10));
            //Console.WriteLine(Methotds.Amperage(10, 5));
            //Console.WriteLine(Methotds.Voltage(2, 5));
            //Console.WriteLine(Methotds.Resistance(2, 10));
            string a = "Dovod";
            //Console.WriteLine((strings1.First(a)));
            //Console.WriteLine((strings1.Second(a)));
            //Console.WriteLine((strings1.Third(a)));
            Bank account = new Bank();
            account.Account("Rouse", "Nent");
            account.Rename("Adel", "Gil");
            account.PaymentAccount(50000, "+");
            account.Info();
        }
    }
}   

