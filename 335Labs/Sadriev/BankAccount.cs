using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev
{
    class BankAccount
    {
        private  string _name;
        private  string _surname;
        private string _id;
        private double _rate = 6.7;
        private double _paymentAccount;

        
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
            _name = reName;
            _surname = reSurname;
            string rakk = _id + " " + _surname + " " + _name;
            return rakk;
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
        public string Info(string ss)
        {
            string ii = _id + " " + _surname + " " + _name + " " + _paymentAccount;
            return ii;
        }















    }
}
