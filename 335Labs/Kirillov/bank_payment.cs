using System;
using System.Collections.Generic;
using System.Text;

    class bank_acc
    {
        public string _name;
        public string _lastname;
        public string _id;
        public string _bankname;

        public void Bank_account_access(string newn, string newsur, string bankn)
        {
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

            Console.WriteLine($"Имя: {_name} Фамилия: {_lastname} Название банка: {_bankname}");
            Console.WriteLine($"ID сессии: {id}");
        }
    }
    