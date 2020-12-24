using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersHealler
{
    class Poison_Touch
    {
        public void FirstAbil(int a, int Mana)
        {

            int mana = 200;

            if (a == 1 & mana >= 40)
            {
                mana = 200 - 40;
                Console.WriteLine("Вы использовали способность Poizon Touch, потратили 40 маны");
            }
            if (a == 0 & mana >= 40)
            {
                Console.WriteLine("Вы не использовали способность Poizon Touch");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
