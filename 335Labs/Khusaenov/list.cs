using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Khusaenov
{
    class BankAccount
    {
        private string _name;
        private string _surname;
        private string _bank;
        private double _id;
        public static double _rate;
        public string _paymentAccount;

        public void SetName(string newName)
        {
            newName = newName.Trim();
            var firstletter = newName[0];
            var otherletters = newName.Remove(0, 1);
            _name = firstletter.ToString().ToUpper() + otherletters;
        }

        public void SetSurname(string newSurname)
        {
            newSurname = newSurname.Trim();
            var firstletter = newSurname[0];
            var otherletters = newSurname.Remove(0, 1);
            _surname = firstletter.ToString().ToUpper() + otherletters;

        }

        public void SetBank(string newBank)
        {
            newBank = newBank.Trim();
            var firstletter = newBank[0];
            var otherletters = newBank.Remove(0, 1);
            _bank = firstletter.ToString().ToUpper() + otherletters;

        }

        public void SetId(int newID)
        {
            Random rnd = new Random();
            int[] ID = new int[1];
            for (int i = 0; i < ID.Length; i++)
            {
                ID[i] = rnd.Next(0, 1000);
            }
            _id = newID;
        }

        public void SetRate(double Rate)
        {
            Random rmd = new Random();
            double[] newRate = new double[1];
            for (int i = 0; i < newRate.Length; i++)
            {
                newRate[i] = rmd.Next(0, 100);
            }
            _rate = Rate;
        }

        public void SetPaymentAccount(string newPaymentAccount)
        {

            _paymentAccount = newPaymentAccount;

        }

       
    }

    
} 

