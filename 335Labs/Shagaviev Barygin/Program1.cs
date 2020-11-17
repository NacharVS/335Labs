using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class Program1
    {
        static void Main(string[] args)
        {
            BankAcc Acc1 = new BankAcc(0, "+79600410599");
            Acc1.Deposit(0);
            MessageSending(Acc1.PhoneNumber, Acc1.Sum);
            AccountCondition(Acc1.PhoneNumber, Acc1.Sum);
        }
        public static void MessageSending(string phoneNumber, int sum)
        {
            Console.WriteLine
        }

    
    }
}
