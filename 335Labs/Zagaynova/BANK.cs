﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using System.Text;

namespace _335Labs.Zagaynova
{
    abstract class BANK
    {
        private string _name;
        private string _surname;
        private string _id;
        private int _age;


        
        public string Registration(string newName, string newSurname, int yy, int mm, int dd)
        {
            int aa = DateTime.Now.Year;
            DateTime date = new DateTime(yy, mm, dd);
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
            _age = aa - date.Year;
            if (date > DateTime.Now.AddYears(-_age)) Age--;
            return "";
        }

        public int Age
        {
            get
            { return _age; }
            set
            { _age = value; }
        }


        public string Edit(string rname, string rsurname)
        {
            rname = rname.Trim();
            var first = rname[0];
            var other = rname.Remove(0, 1);
            _name = first.ToString().ToUpper() + other.ToLower();
            rsurname = rsurname.Trim();
            var firsts = rsurname[0];
            var others = rsurname.Remove(0, 1);
            _surname = firsts.ToString().ToUpper() + others.ToLower();
            string reakk = _id + " " + _name + " " + _surname;
            return reakk;
         }
        public string Info()
        {
            string ifoss = _id + " " + _name + " " + _surname + "\n"  +  "age:" + _age;
            return ifoss;
        }

    }
      class Client : BANK 
      {
            private double _paymentAccount;
            private static double _Stavka = 0.067;
            private DateTime _accountOpenDate;
            


        public void RegistrAccount( double sum, int yy, int  mm, int dd)
             {
            _paymentAccount = sum;
            _accountOpenDate = new DateTime(yy, mm, dd);
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
            
            public double Proc()
            {
            DateTime datnow = DateTime.Now;
            int year = datnow.Year - _accountOpenDate.Year;
            int mounth = datnow.Month - _accountOpenDate.Month +  year * 12;
             for (int i = 1; i <= mounth; i++)
            {
                _paymentAccount += _paymentAccount * _Stavka;
            }
               return _paymentAccount;
            }
            public static void ReProc(double newProc)
            {
                _Stavka = newProc / 100;
            }

            public void ShowInfo()
            {
            string inf = Info() + "\n" + "money in the account" + _paymentAccount;
            Console.WriteLine(inf);
            }
       }
    class Employee : BANK
    {
        private string _post;
        public string  Post
        {
            get
            { return _post; }
            set
            { _post = value; }
        }
        public void ShowInfo()
        {
            string inf = Info() + "\n" + "Post-" + _post;
            Console.WriteLine(inf);
        }
    }


















 }

    