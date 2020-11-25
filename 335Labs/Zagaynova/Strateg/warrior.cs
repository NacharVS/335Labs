using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class warrior: IObch, Iformov, Iforshoot
    {
        string _name;
        int _health;
        string _weapon;
        int _speed;
        string _way;
        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = 100; }
        public string Weapon { get => _weapon; set => _weapon = value; }
        public int Speed { get => _speed; set => _speed = 7; }
        public string Way { get => _way; set => _way = "On foot"; }


        public void Attack()
        {
            if (_health >= 0)
            {
                Console.WriteLine($"warrior{_name} attacks. Weapon{_weapon}");
            }
            else
            {
                Console.WriteLine($"life os over");
            }
        }
    }
}
