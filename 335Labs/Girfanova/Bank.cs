using System;

namespace bankaccount
{
    abstract class Bank
    {
        private string _name;
        private string _surn;
        private string _id;
        private int _age;
        private string _phnum;

        public string Reg(string nName, string nSurn, string phnumber, int year, int month, int day)
        {
            nName = nName.Trim();
            var fln = nName[0];
            var nln = nName.Remove(0, 1);
            _name = fln.ToString().ToUpper() + nln.ToLower();

            nSurn = nSurn.Trim();
            var fls = nSurn[0];
            var nls = nSurn.Remove(0, 1);
            _surn = fls.ToString().ToUpper() + nls.ToLower();

            _phnum = phnumber;

            Random rnd = new Random();
            int a = rnd.Next(10000, 99999);
            _id = a.ToString();

            int datenow = DateTime.Now.Year;
            DateTime date = new DateTime(year, month, day);

            _age = datenow - date.Year;

            if (date > DateTime.Now.AddYears(-_age)) 
                Age--;

            string ua = "Name:" + _name + "Surname:" + _surn + "UID:" + _id + "Age:" + _age + "Phone number:" + _phnum;
            return ua
        ;
        }

        public int Age {get {return _age;} set {_age = value;} }


        public string RedactAcc(string redName, string redSurn)
        {
            redName = redName.Trim();
            var first = redName[0];
            var other = redName.Remove(0, 1);
            _name = first.ToString().ToUpper() + other.ToLower();

            redSurn = redSurn.Trim();
            var firsts = redSurn[0];
            var others = redSurn.Remove(0, 1);
            _surn = firsts.ToString().ToUpper() + others.ToLower();

            string redacc = "Name:" + _name + "Surname:" + _surn + "UID:" + _id;
            return redacc;
        }

        public string AccInfo()
        {
            string infoacc = "Name:" + _name + "Surname:" + _surn + "UID:" + _id + "Age:" + _age;
            return infoacc;
        }
    }
}