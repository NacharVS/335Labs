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

        
        public  void regist(string newName,string newSurname)
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
            int a = rnd.Next(1, 100000);
            _id = $"{a}";
            Console.WriteLine($"Name:{_name} Surname:{_surname}   ID:{_id}");
        }
        public void rename(string reName, string reSurname)
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
            int a = rnd.Next(1, 100000);
            _id = $"{a}";
            Console.WriteLine($"Name:{_name}     Surname:{_surname}     ID:{_id}");
        }


        public void PaymentAc(int a, string b)
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
                Console.WriteLine("payment:  " + _paymentAccount);
            
        }






        
        






    }
}
