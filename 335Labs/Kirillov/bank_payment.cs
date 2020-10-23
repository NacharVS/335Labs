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
            var firstLetter = newn[0];
            var otherLetters = newn.Remove(0, 1);
            _name = firstLetter.ToString().ToUpper() + otherLetters;
            newsur = newsur.Trim();
            var firstLetterr = newsur[0];
            var otherLetterrs = newsur.Remove(0, 1);
            _lastname = firstLetterr.ToString().ToUpper() + otherLetterrs;
            Console.WriteLine(newsur);
            Random rnd = new Random();
            int a = rnd.Next(888, 88888888);
            _id = $"{a}";
            Console.WriteLine($"Имя: {_name} Фамилия: {_lastname}");
            Console.WriteLine($"#ID: {a}");
        }
    }
}
    