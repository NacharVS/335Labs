using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov
{
    class Bank
    {

        private string _name;
        private string _lastname;
        private string _id;
        private double _paymentAccount;
        private int _age;

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
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Last Name: { _lastname}");
          


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
        
        public int Age
        {
            get
            {
                if (_age > 14 & _age < 150)
                    return _age;
                else Console.WriteLine("error");
                return Age;
            }
            set
            {
                _age = value;
            }
        }
        public void Info()
        {
            string ii = _id + " " + " " + _lastname + " " + _name;
            Console.WriteLine(ii);
        }

    }
    class Client : Person
    {
        private static double _rate = 6.7;
        private double _paymentAccount;
        public double PaymentAc(double a, string b)
        {
            if (b == "+")
            {
                if (a < 10000) { Console.WriteLine("minimum  10000"); }
                else _paymentAccount += +a;
            }
            else if (b == "-")
            {
                if (a > 200000) { Console.WriteLine("maximum  200000"); }
                else _paymentAccount = _paymentAccount - a;
            }
            return _paymentAccount;
        }
        public void PaymentAc()
        {
            Console.WriteLine("payment:  " + _paymentAccount);
        }
        public void InfoC()
        {
            string ii = "Money:   " + _paymentAccount;
            Console.WriteLine(ii);
        }
        public double Rate()
        {
            _paymentAccount += _paymentAccount * _rate / 100;
            return _paymentAccount;
        }
        public static void Rerate(double rerate)
        {
            _rate = rerate;
        }
    }
    class Employee : Person
    {
        private string _position;
        public string position
        {
            get
            { return _position; }
            set
            { _position = value; }
        }
        public void InfoE()
        {
            string ii = "Position: " + _position;
            Console.WriteLine(ii);
        }

    }

}

