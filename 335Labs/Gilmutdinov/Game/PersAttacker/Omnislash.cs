using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersAttacker
{
    class Omnislash
    {
        public void SecondAbil(int a, int Mana)
        {
            int mana = 100;
            if (a == 1 & mana >= 35)
            {
                mana = 100 - 35;
                Console.WriteLine("Вы использовали способность Omnislash");
            }
            if (a == 0 & mana >= 35)
            {
                Console.WriteLine("Вы не использовали способность Omnislash");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
