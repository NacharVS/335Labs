using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Girfanova.Strategy
{
    class Warrior : IHealth, IAttack, IName
    {
        string _name;
        int _hp, _atk;
        public string name { get => _name; set => _name = value; }
        public int hp { get => _hp; set => _hp = 100; }
        public int atk { get => _atk; set => _hp = 100; }
    }

}
