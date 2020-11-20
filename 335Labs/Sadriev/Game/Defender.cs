using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev.Game
{
    class Defender : Heroes, IHealTeam
    {
        public Defender(int power,
            int vision,
            int health
            ) : base(power, vision, health)
        {

        }
        public void HealTeam(Heroes heroes)
        {
            if (dead == false)
            {
                if (heroes.dead == false)
                {
                    heroes.Health += Health + Power;
                    Console.WriteLine($"герой захилен\n" +
                        $"его хп {heroes.Health}");
                }
                else
                {
                    Console.WriteLine("Герой умер, вы опаздали");
                }
            }
            else
            {
                Console.WriteLine("Вы мертвы, с того света лечить нельзя");
            }
        }
    }
}
