using System;

namespace _335Labs
{
    class Program
    {

        private string _name;
        private string _lastname;
        private string _id;
        private double _paymentAccount;
        
        public void Account(string newName, string newLastname)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
            newLastname = newLastname.Trim();
            var firstLetterr = newLastname[0];
            var otherLetterrs = newLastname.Remove(0, 1);
            _lastname = firstLetterr.ToString().ToUpper() + otherLetterrs;
            Random rnd = new Random();
            int a = rnd.Next(888, 88888888);
            _id = $"{a}";
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Last Name: { _lastname}");
            Console.WriteLine($"#ID: {a}");
        }
        public void Rename(string reName, string reLastname)
        {
            reName = reName.Trim();
            var firstLetter = reName[0];
            var otherLetters = reName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
            reLastname = reLastname.Trim();
            var firstLetterr = reLastname[0];
            var otherLetterrs = reLastname.Remove(0, 1);
            _lastname = firstLetterr.ToString().ToUpper() + otherLetterrs;
            Random rnd = new Random();
            int a = rnd.Next(888, 88888888);
            _id = $"{a}";
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Last Name: { _lastname}");
            Console.WriteLine($"#ID: {a}");
        }
        public double PaymentAccount(double a, string b)
        {
            if (b == "+")
            {
                if (a < 10000) { Console.WriteLine("min 10000"); }
                else _paymentAccount += +a;
            }
            else if (b == "-")
            {
                if (a > 200000) { Console.WriteLine("max 200000"); }
                else _paymentAccount = _paymentAccount - a;

            }
            return _paymentAccount;
        }
        public void PaymentAccount()
        {
            Console.WriteLine("payment:" + _paymentAccount);
        }
        public void Info()
        {
            string Info = _id + "_" + _lastname + "_" + _name + "_" + _paymentAccount;
            Console.WriteLine(Info);
        }
    }
}
