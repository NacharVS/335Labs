using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game
{
    class Heroes
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        
        public bool dead;

        public Heroes(int health, int power, int speed)
        {
            Health = health;
            Power = power;
            Speed = speed;
            
        }
    }
}
