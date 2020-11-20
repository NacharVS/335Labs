using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev.Game
{
    class Heroes
    {
        public int Power { get; set; }
        public int Vision { get; set; }
        public int Health { get; set; }

        public bool dead;

        public Heroes(int power,int vision, int health)
        {
            Power = power;
            Vision = vision;
            Health = health;
        }
    }
}

