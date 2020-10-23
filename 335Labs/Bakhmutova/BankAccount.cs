using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _id;
        private string _paymentAccount;

        public void MakeDeposit(decimal amount, DateTime date, string note) { }
        public void MakeWithdrawal(decimal amount, DateTime date, string note) { }
        Account[] accounts;

        public void Registration(string n, string s)
        //public static void Registration(Bank<T> where T : Account)
        {
            n = n.Trim();
            s = s.Trim();
            var firstLet = n[0];
            var otherLet = n.Remove(0, 1);
            _name = n.ToString().ToUpper() + s.ToString().ToUpper();
            Random rn = new Random();
            int id = rn.Next(1000, 9999);
            Console.WriteLine($"id: { id}");
            //     int k = 0;
            // foreach () { }

        }
        public enum AccountType { Deposit }
        public void Open(AccountType accountType, decimal sum,
       AccountStateHandler addSumHandler, AccountStateHandler withdrawSumHandler,
       AccountStateHandler calculationHandler, AccountStateHandler closeAccountHandler,
       AccountStateHandler openAccountHandler)
        {
            BankAccount newAccount = null;

            switch (accountType)
            {
                case AccountType.Ordinary:
                    newAccount = new DemandAccount(sum, 1) as T;
                    break;
                case AccountType.Deposit:
                    newAccount = new DepositAccount(sum, 40) as Account;
                    break;
            }
        }
    }

   
    
}
