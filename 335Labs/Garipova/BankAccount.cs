using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova
{
    public class BankAccount
    {
        public delegate void SumChanged(string phonenumber, int sum);
        public delegate void RateChanged(double oldRate, double newRate);
        private string _name;
        private string _surname;
        private string _id;
        private static double _rate = 0.35;
        private DateTime accountOpenDate;
        private double _paymentAccount;
        private int _sum;
        private string _phoneNumber;
        public BankAccount(int sum, string phonenumber)
        {
            _sum = sum;
            _phoneNumber = phonenumber;
        }







        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(0, "+79385635564");
            acc1.Deposit(100);
        }

        public static void MessageSending(string phoneNumber, int sum)
        {
            Console.WriteLine($"Message send at {phoneNumber}");
        }
        public static void AccountCondition(string phoneNumber, int sum)
        {
            Console.WriteLine($"Account value {sum}");
        }
        public double Rate
        {
            get
            {
                return _rate;
            }

            set
            {
                var oldRate = _rate;
                _rate = value;
                RateChangedEvent?.Invoke(oldRate, _rate);
            }
        }

        public event RateChanged RateChangedEvent;

        public void Deposit(int sum)
        {
            sum += sum;
        }

        public void Widthraw(int sum)
        {
            sum -= sum;
        }

        public void RateChange(double newRate)
        {
            Rate = newRate;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{_name} {_surname} {_id} {_paymentAccount}");
        }
        private static void Main(string[] args)
        {
            int a = DateTime.Now.Year;
            DateTime dayofbrith = new DateTime(16, 11, 1999);
            Console.WriteLine($"day=(dayofbrith.Day) month=(dayofbrith.Monday) year=(dayofbrith.Year)");



       }

}