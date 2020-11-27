using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game
{
    class HealHeroes
    {
        public HealHeroes(int health, int power, int speed) 
        {
            Console.WriteLine($"Активная способность: Герой может захилить на 30 единиц");
        }
        public void HealTeam(Heroes heroes)
        {
            if (heroes.Health >= 1)
            {
                heroes.Health = heroes.Health + 30;
                Console.WriteLine($"герой захилен" +
                    $"его хп {heroes.Health}");
            }
            else
            {
                Console.WriteLine("Герой умер");
            }
        }
    }
}
