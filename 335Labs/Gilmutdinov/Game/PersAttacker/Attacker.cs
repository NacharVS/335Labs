using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game
{
    class Attacker : AbilityAttacker
    {
        string _name;
        int _health = 739;
        int _speed = 250;
        int _power = 70;
        string _weapon;
        int mana = 200;


        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; }
        public int Speed { get => _speed; }
        public int Power { get => _power; }
        public string Weapon { get => _weapon; set => _weapon = "blade"; }
    }
}
