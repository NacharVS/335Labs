using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game
{
    class Tank: AbilityTank
    {
        string _name;
        int _health = 1200;
        int _speed = 200;
        int _power = 50;
        string _weapon;
        int mana = 200;


        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; }
        public int Speed { get => _speed; }
        public int power { get => _power; }
        public string Weapon { get => _weapon; set => _weapon = "shield"; }
    }
}
