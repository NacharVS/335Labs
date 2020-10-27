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
            Console.WriteLine("Введите название вашего банка: ");
            string bankn = Console.ReadLine();

            bank_acc bankacc = new bank_acc();
            bankacc.Bank_account_access(newn, newsur, bankn);

        }
    }
}
