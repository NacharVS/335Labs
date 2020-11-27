using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class Tower : IObch, Iforshoot
    {
        string _name;
        int _health;
        string _weapon;
        int _kol;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = 100; }
        public string Weapon { get => _weapon; set => _weapon = "Kernels"; }
        public int kol { get => _kol; set => _kol = value; }



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
        public void Shoot(int kol)
        {
            if (_kol <= kol)
            {
                for (int i = 1; i >= kol; i++)
                {
                    Console.WriteLine("Shoot");
                }
            }
            else Console.WriteLine("No cartridges");

        }
    }
}
