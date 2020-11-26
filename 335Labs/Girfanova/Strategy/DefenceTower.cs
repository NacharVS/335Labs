using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Girfanova.Strategy
{
    class DefenceTower : IName, IDefence
    {
        string _name;
        int _hp, _def;
        public string name { get => _name; set => _name = value; }
        public int def{ get => _def; set => _def = 200; }
    }
}
