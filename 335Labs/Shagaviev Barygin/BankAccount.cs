using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
{
    class BankAccount
    {
        public static void UserAcc()
        {
            Console.Write("Введите ФИО: ");
            String s = Console.ReadLine();

          
        }
        private string _name;
        private string _surname;
        private string _id;
        private Double _PaymentAccount; 
        
        public void SetName(string newName)
        {
            int index = _name.IndexOf(' ');
            newName = newName.Trim();
            var firstLetter = newName[0];
            var otherLetters = newName.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
           
         
        }
        public class AccountAction
        {
            public DateTime Date { get; set; }

            public ActionType Type { get; set; }

            public decimal Amount { get; set; }
        }




    }

    public class ActionType
    {
    }
}
