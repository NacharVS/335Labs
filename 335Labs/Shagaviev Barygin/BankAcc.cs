using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class BankAcc
    {
        public delegate void SumChanged(string phonenumber, int sum);
        public delegate void RateChanged(double oldRate, double newRate);
        private int _sum;
        private static double _rate = 0.35;
        private DateTime _accountOpenDate;
        private String _phoneNumber;
        public BankAcc(int sum, string phoneNumber)
        {
            _sum = sum;
            _phoneNumber = phoneNumber;
        }
        public void Sum()
        {

        }
        public void Deposit(int sum)
        {
            sum += ;
        }

        public void Withdraw(int sum)
        {
            sum -= sum;
        }
        public void ShowProfit(DateTime timeNow)
        {
            _sum += _sum * _rate;
        }
        public static void RateChangedd(double newRate)
        {
            _rate = newRate;
        }
        
            
           
    

    }
}
