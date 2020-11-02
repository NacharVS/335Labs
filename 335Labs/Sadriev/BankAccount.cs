using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _335Labs.Sadriev
{
    class Person
    {
        private  string _name;
        private  string _surname;
        private string _id;
        private int _age;



        public string Regist(string newName, string newSurname, int year, int mouth, int day)
        {
            newName = newName.Trim();
            var FL= newName[0];
            var OL = newName.Remove(0, 1);
            _name = FL.ToString().ToUpper() + OL.ToLower();
            newSurname = newSurname.Trim();
            var fl = newSurname[0];
            var ol = newSurname.Remove(0, 1);
            _surname = fl.ToString().ToUpper() + ol.ToLower();
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            _id = $"{a}";
            int now = DateTime.Now.Year;
            DateTime d = new DateTime(year, mouth, day);
            _age = now -d.Year;
            if (d > DateTime.Now.AddYears(-_age)) Age--;
            string akk = _id + " " + _surname + " " + _name + " " + _age;
            return akk;
        }
        public string Rename(string reName, string reSurname)
        {
            reName = reName.Trim();
            var FL = reName[0];
            var OL = reName.Remove(0, 1);
            _name = FL.ToString().ToUpper() + OL.ToLower();
            reSurname = reSurname.Trim();
            var fl = reSurname[0];
            var ol = reSurname.Remove(0, 1);
            _surname = fl.ToString().ToUpper() + ol.ToLower();
            string reak = _id + " " + _surname + " " + _name;
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
            string ii =  "Money:   " + _paymentAccount;
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
