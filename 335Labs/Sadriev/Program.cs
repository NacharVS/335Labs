using _335Labs.Sadriev;
using System;

namespace _335Labs.Sadriev.Delegates
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Regist("alena", "alinovna","79991678862", 1980, 12, 15);
            client.PaymentAc(30000, "+");
            client.PaymentAc(10000, "-");
            client.Rename("     gafur", "      tentovich");
            client.Rate();
            client.Info();
            client.InfoC();
            Console.WriteLine("  ");
            Employee emp = new Employee();
            emp.Regist("Muhamed", "Ibragimov","78965645643", 1993, 6, 17);
            emp.Rename("   murat", "  absalov");
            emp.position = "Director";
            emp.Info();
            emp.InfoE();













            //int[] array = { 1, 2, 43, 76, 12 };
            //int[] array1 = { 12, 645, 12, 65, 51};
            //Branchs.DuoMassiv test2;
            //test2 = General.DuoSum;
            //test2 = General.DuoMult;
            //test2(array, array1);
            //Branchs.SoloMassiv test1;
            //test1 = General.Max;
            //test1(array);





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
