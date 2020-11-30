using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersHealler
{
    class Poison_Touch
    {
        public void FirstAbil(int a)
        {

            int mana = 200;

            if (mana >= 40)
            {
                mana = 200 - 40;
                Console.WriteLine("Вы использовали способность Fireblast, потратили 40 маны");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
