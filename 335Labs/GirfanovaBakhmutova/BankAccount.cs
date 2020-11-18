using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.GirfanovaBakhmutova
{
    class BankAccount
    {
        BankAccount acc1 = new BankAccount(0, "+79150346722");
        acc1.RateChangingEvent +=RateChangingNotify;
      //  acc1.Deposit();

        public delegate void SumChanging(string phnumber, int sum);
        public delegate void RateChanging(double OldRate, double NewRate);
        private int _sum;
        private static double _rate = 0.35;
        private DateTime _accountOpenDate;
        private string _phnumber;

        public BankAccount(int sum, string phnumber)
        {
            _sum = sum;
            _phnumber = phnumber;
        }

        public int Sum
        {
            get
            {
                return _sum;
            }
            private set
            {
                _sum = value;
                SumChangingEvent?.Invoke(_phnumber, _sum);
            }
        }
        public event SumChanging SumChangingEvent;
        public string phnumber
        {
            get
            {
                return phnumber;
            }
            private set
            {
                _phnumber = value;
            }
        }
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                _rate = value;
            }
        }
        public event RateChanging RateChangingEvent;
        public void Deposit(int sum)
        {
            Sum += sum;
        }
        public void Widthraw(int sum) 
        {

        }

        public static void MessageSending(string phnumber, int sum)
        {
            Console.WriteLine($"Message sent at {phnumber}");
        }

        public static void AccountState(string phnumber, int sum)
        {

        }
    }
}
