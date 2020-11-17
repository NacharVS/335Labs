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
        private string _phonenumber;
        public string Regist(string newName, string newSurname,string phone, int year, int mouth, int day)
        {
            newName = newName.Trim();
            var FL= newName[0];
            var OL = newName.Remove(0, 1);
            _name = FL.ToString().ToUpper() + OL.ToLower();
            newSurname = newSurname.Trim();
            var fl = newSurname[0];
            var ol = newSurname.Remove(0, 1);
            _surname = fl.ToString().ToUpper() + ol.ToLower();
            _phonenumber = phone;
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            _id = $"{a}";
            int now = DateTime.Now.Year;
            DateTime d = new DateTime(year, mouth, day);
            _age = now -d.Year;
            if (d > DateTime.Now.AddYears(-_age)) Age--;
            string akk = _id + " " + _surname + " " + _name + " " + _age + " "+ _phonenumber;
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
            string ii ="\n Id: " +  _id + " " + "\t Surname: " + _surname + "\t Name: " + _name + "\t Age: "+ _age +"\t Phone number:   "+_phonenumber;
            Console.WriteLine(ii);
        }

    }
    class Client : Person
    {
        private static double _rate = 0.035;
        private double _sum;
        private DateTime _accountOpenningDate;
        //public delegate void SumChanged
        public double PaymentAc(double a, string b)
        {
            if (b == "+")
            {
                if (a < 10000) { Console.WriteLine("minimum  10000"); }
                else _sum += +a;
            }
            else if (b == "-")
            {
                if (a > 200000) { Console.WriteLine("maximum  200000"); }
                else _sum = _sum - a;
            }
            return _sum;
        }
        public void PaymentAc()
        {
            Console.WriteLine("payment:  " + _sum);
        }
        public void InfoC()
        {
            string ii = "Money:   " + _sum;
            Console.WriteLine(ii);
        }
        public double Rate()
        {
            _sum += _sum * _rate / 100;
            return _sum;
        }
        public static void Rerate(double rerate)
        {
            _rate = rerate;
        }
        public void AcRegist(double sum, int yy, int mm, int dd)
        {
           



        }
        public void Showprofit()
        { 
            


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
