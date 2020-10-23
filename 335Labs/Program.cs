using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Kirillov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string newn = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            string newsur = Console.ReadLine();

            bank_acc bankacc = new bank_acc();
            bankacc.Bank_Account(newn, newsur);

        }
    }
}
