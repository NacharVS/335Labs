using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Text;

namespace _335Labs.Zagaynova
{
    class BANK
    {
        private string _name;
        private string _surname;
        private string _id;

        private double _paymentAccount;

        public string Registration(string newName, string newSurname)
        {
            newName = newName.Trim();
            var first = newName[0];
            var other = newName.Remove(0, 1);
            _name = first.ToString().ToUpper() + other.ToLower();
            newSurname = newSurname.Trim();
            var firsts = newSurname[0];
            var others = newSurname.Remove(0, 1);
            _surname = firsts.ToString().ToUpper() + others.ToLower();
            Random rnd = new Random();
            int a = rnd.Next(1000, 9999);
            _id = a.ToString();
            string newakk = _id + " " + _name + " " + _surname;

            return newakk;

        }
        public double PaymentAc(int a, string s)
        //положить минимум 10 000
        //снять максимум 200 000
        {

            if (s == "Sum")
            {

                if (a < 10000) { Console.WriteLine("minimum amount 10 000"); }
                else _paymentAccount += +a;
            }
            else if (s == "Sub")
            {

                if (a > 200000) { Console.WriteLine("maximum amount 200 000"); }
                else _paymentAccount = _paymentAccount - a;
            }
            return _paymentAccount;
        }

        public void PaymentAc()
        {
            Console.WriteLine(_paymentAccount);

        }
        public string Edit(string rname, string rsurname)
        {
            _name = rname;
            _surname = rsurname;
            string reakk = _id + " " + _name + " " + _surname;

            return reakk;
        }

        public string Info(string ss)

        {
            string ifoss = _id + " " + _name + " " + _surname  + " " + _paymentAccount;
            return ifoss;
        }   
           
            
    }


}
   