using System;


namespace _335Labs.Gayfullin
{
    delegate void Massive(string mes);
    class Program
    {



        static void SayHello(string str)
        {
            Console.WriteLine(str);

        }


        static void Main(string[] args)
        {

            Massive[] jj = new 6Massive[5];
            Massive[] ff = new Massive[5];

        }
        static int[] Equal(int[] jj, int[] ff)
        {
            Massive[] vv = new Massive[5];
            for (int i = 0; i < jj.Length; i++)
            {

                vv[i] = jj[i] + ff[i];
                vv[i](Convert.ToString(i));
            }
            return vv;


            Console.ReadKey();

        }






    }
}
