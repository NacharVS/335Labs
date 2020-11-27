using System;
using System.Collections.Generic;
using System.Text;


namespace _335Labs.Shagaviev_Barygin.GAME
{
    class Heroes
    {
        public int Power { get; set; }
        public int Health { get; set; }

        public bool dead;

        public Heroes(int power, int health)
        {
            Power = power; //сила
            Health = health; //здоровье
        }


    }
}
