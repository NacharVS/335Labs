using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _335Labs.Sadriev
{
    class BankAccount
    {
        private  string _name;
        private  string _surname;
        private string _id;
        private static double _rate = 6.7;
        private double _paymentAccount;
        private int _age;

        
        public  string Regist(string newName,string newSurname)
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
            string akk = _id + " " + _surname + " " + _name; 
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
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            _id = $"{a}";
            string reak = _id + " " + _surname + " " + _name;
            return reak;
        }

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
            Console.WriteLine("payment:  "+ _paymentAccount);
        }
        public void Info()
        {
            string ii = _id + " "+_age+ " " + _surname + " " + _name + " " + _paymentAccount;
            Console.WriteLine(ii) ;
        }
        public double Rate()
        {
            _paymentAccount +=  _paymentAccount * _rate/100;
            return _paymentAccount;
        }
        public static void Rerate(double rerate)
        {
            _rate = rerate ;
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                int a = DateTime.Now.Year;
                _age = a - value;
            }





        }















    }
}
