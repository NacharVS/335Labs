using System;
using System.Collections.Generic;
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

        public  void Registration(string newName , string newSurname)
        {
            newName= newName.Trim();
            var first = newName[0];
            var other = newName.Remove(0, 1);
            _name = first.ToString().ToUpper() + other.ToLower();
            newSurname = newName.Trim();
            var firsts = newName[0];
            var others = newName.Remove(0, 1);
            _surname = first.ToString().ToUpper() + other.ToLower();
            Random rnd = new Random();
            int a = rnd.Next(1000, 9999);
            _id = a.ToString();

            Console.WriteLine($" id {_id} Name {_name} Surname {_surname}");
        }



    }
}
