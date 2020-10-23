using _335Labs.Khusaenov;
using System;

namespace _335Labs
{
    class Program
    {

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Введите Имя");
            account.SetName(Console.ReadLine());
            Console.WriteLine("Введите Фамилию");
            account.SetSurname(Console.ReadLine());
            Console.WriteLine("Название Банка");
            account.SetBank(Console.ReadLine());
            Console.WriteLine();
            
        }
    }
}
