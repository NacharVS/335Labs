using System;
using System.Collections.Generic;
using System.Text;

    class bank_acc
    {
        private string _name;
        private string _lastname;
        private string _id;
        private string _bankname;

        public void Registration(string newn, string newsur, string bankn)
        {
            Console.WriteLine(DateTime.Now);
            //Имя
            newn = newn.Trim();
            var first = newn[0];
            var second = newn.Remove(0, 1);
            _name = first.ToString().ToUpper() + second;
            //Фамилия
            newsur = newsur.Trim();
            var firstt = newsur[0];
            var secondd = newsur.Remove(0, 1);
            _lastname = firstt.ToString().ToUpper() + secondd;
            //Рандомный id сессии
            Random rnd = new Random();
            int  id = rnd.Next(888, 88888888);
            _id = $"{id}";
            //Название банка
            bankn = bankn.Trim();
            var three = bankn[0];
            var four = bankn.Remove(0, 1);
            _bankname = three.ToString().ToUpper() + four;

           
        }
        public void Account_info()
        {
            Console.WriteLine($"Имя: {_name} Фамилия: {_lastname} Название банка: {_bankname}");
            Console.WriteLine($"ID сессии: {_id}");
        }
        
        public void Account_payment(double dollar)
        {
            Console.WriteLine(DateTime.Now);
            
        }
    }
    