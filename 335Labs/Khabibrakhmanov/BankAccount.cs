﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Khabibrakhmanov
{
    class BankAccount
    {
        private string _name;
        private string _lastname;
        private string _id;
        private string _paymentAccount;

        public  void Account(string newName, string newLastname)
        {
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
            newLastname = newLastname.Trim();
            var firstLetterr = newLastname[0];
            var otherLetterrs = newLastname.Remove(0, 1);
            _lastname = firstLetterr.ToString().ToUpper() + otherLetterrs;
            Console.WriteLine(newLastname);
            Random rnd = new Random();
            int a = rnd.Next(888, 88888888);
            _id = $"{a}";
            Console.WriteLine($"Name: {_name} Last Name: {_lastname} #ID: {a}");
        }
    }
}
