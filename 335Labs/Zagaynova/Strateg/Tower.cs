using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova.Strateg
{
    class Tower : IObch, Iforshoot
    {
        string _name;
        int _health;
        string _weapon;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = 100; }
        public string Weapon { get => _weapon; set => _weapon = "Kernels"; }

        public void Protection()
        {
            if (_health >= 0)
            {
                Console.WriteLine($"Tower {_name}  Weapon{_weapon}");
            }
            else
            {
                Console.WriteLine($"life os over");
            }
        }
    }
}
