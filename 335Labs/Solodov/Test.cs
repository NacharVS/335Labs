using System;
using System.Collections.Generic;
using System.Text;


namespace _335Labs.Gayfullin
{
    class MathMetods
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Добрый день, введите ID-номер вашего счета и выберите операцию: 1 - снять со счета. 2 - положить на счет. 3 - посмотреть информацию о счете. 4 - депозит.");
            int a = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int b = 40000;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Укажите сумму, которую вы хотите снять со счета:");
                    int c = int.Parse(Console.ReadLine());
                    if (c < 5000)
                        b = b - c;
                    break;
                case 2:
                    Console.WriteLine("Укажите сумму, которую вы хотите положить на счет:");
                    int v = int.Parse(Console.ReadLine());
                    if (v < 12000)
                        b = b + v;
                    break;
                case 3:
                    Console.WriteLine("Информация о вашем счете:");
                    Console.WriteLine("ID-номер счета :");
                    Console.WriteLine($"{q}");
                    Console.WriteLine("Сумма денег на счету:");
                    Console.WriteLine($"{b}");
                    break;
                case 4:
                    Console.WriteLine("Введите сумму депозита(не более 20000, не менее 4000:");
                    int g = int.Parse(Console.ReadLine());
                    break;
            }
        }



    }
}
