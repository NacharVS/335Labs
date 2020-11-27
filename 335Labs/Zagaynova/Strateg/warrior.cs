using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class warrior: IObch, Iformov, Iforshoot
    {
        string _name;
        int _health=100;
        string _weapon;
        int _speed;
        string _way;
        int _kol;
        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; }
        public string Weapon { get => _weapon; set => _weapon = value; }
        public int Speed { get => _speed; set => _speed = 7; }
        public string Way { get => _way; set => _way = "On foot"; }
        public int kol { get => _kol; set => _kol = value; }


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
