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

        public void Registration(string n, string s)
        {
            n=n.Trim();
            s = s.Trim();
            var firstLet = n[0];
            var otherLet = n.Remove(0,1);
            _name = n.ToString().ToUpper() + s.ToString().ToUpper();
            Random rn = new Random();
            int id = rn.Next(1000, 9999);
            Console.WriteLine($"id: { id}");
       //     int k = 0;
           // foreach () { }
        }
    }
}
