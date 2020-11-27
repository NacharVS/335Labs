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
            int  id = rnd.Next(101, 213213123);
            _id = $"{id}";
            //Название банка
            bankn = bankn.Trim();
            var three = bankn[0];
            var four = bankn.Remove(0, 1);
            _bankname = three.ToString().ToUpper() + four;

           
        }
        public void Account_info()
        {
            Console.WriteLine("Текущая дата: " + DateTime.Now);
            Console.WriteLine($"ID сессии: {_id}");
            Console.WriteLine($"Имя: {_name} Фамилия: {_lastname} Название банка: {_bankname}");
            
        }

        public double Account_payment(string a, int b, double _sum)
        {
            Console.WriteLine(DateTime.Now);
            //положить минимум 10 000
            if (a == "+")
            {
                if (b < 10000)
                {
                    Console.WriteLine("Минимальное пополнение - 10000 рублей!");

                }
                else _sum += b;
            }

            //снять максимум 200 000
            if (a == "-")
            {
                if (b < 200000)
                {
                    Console.WriteLine("Минимальное снятие - 200000 рублей!");
                }
                else _sum -= b;
            }
            Console.WriteLine($"money in  the account : {_sum}");
            return _sum;
            
    }


}
    