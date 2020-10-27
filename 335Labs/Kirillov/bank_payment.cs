using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Kirillov

{
    class bank_acc
    {
        private string _name;
        private string _lastname;
        private string _id;

        public void Bank_Account(string newn, string newsur)
        {
            newn = newn.Trim();
            var first = newn[0];
            var second = newn.Remove(0, 1);
            _name = first.ToString().ToUpper() + second;
            newsur = newsur.Trim();
            var firstt = newsur[0];
            var secondd = newsur.Remove(0, 1);
            _lastname = firstt.ToString().ToUpper() + secondd;
            Console.WriteLine(newsur);
            Random rnd = new Random();
            int  id = rnd.Next(888, 88888888);
            _id = $"{id}";
            Console.WriteLine($"Имя: {_name} Фамилия: {_lastname}");
            Console.WriteLine($"ID сессии: {id}");
        }
    }
}
    