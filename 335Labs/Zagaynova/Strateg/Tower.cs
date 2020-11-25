using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova.Strateg
{
    class Tower:IObch,Iforshoot
    {
        string _name;
        int _health;
        string _weapon;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = 100; }
        public string Weapon { get => _weapon; set => _weapon = "Kernels"; }

    }
}
