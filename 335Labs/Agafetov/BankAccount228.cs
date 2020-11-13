using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Agafetov
{    
    class BankAccount
    class Person
    {
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 6.7;
        private double _paymentAccount;
        private int _age;


        public string Regist(string newName, string newSurname)


        public string Regist(string newName, string newSurname, int year, int mouth, int day)
        {
            newName = newName.Trim();
            var FL = newName[0];
            public string Regist(string newName, string newSurname)
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            _id = $"{a}";
            string akk = _id + " " + _surname + " " + _name;
            int now = DateTime.Now.Year;
            DateTime d = new DateTime(year, mouth, day);
            _age = now - d.Year;
            if (d > DateTime.Now.AddYears(-_age)) Age--;
            string akk = _id + " " + _surname + " " + _name + " " + _age;
            return akk;
        }
        public string Rename(string reName, string reSurname)
            public string Rename(string reName, string reSurname)
            return reak;
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
            string ii = _id + " " + " " + _surname + " " + _name;
            Console.WriteLine(ii);
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
            if (b == "+")
            {
                if (a < 10000) { Console.WriteLine("minimum  10000"); }
                else _paymentAccount += +a;
            }
            else if (b == "-")
            {

                if (a > 200000) { Console.WriteLine("maximum  200000"); }
                else _paymentAccount = _paymentAccount - a;

                if (a > 200000) { Console.WriteLine("maximum  200000"); }
                else _paymentAccount = _paymentAccount - a;
            }

            return _paymentAccount;
        }
    } 
}
