using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.rpg
{
    public class Player
    {
        private int _health,
            _maxHealth,
            _power,
            _money;


        public int Health
        {
            get { return _health; }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
        }

        public int Power
        {
            get { return _power; }
        }

        public int Money
        {
            get { return _money; }
        }

    }
}
