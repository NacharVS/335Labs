using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersAttacker
{
    class Omnislash
    {
        public void SecondAbil(bool a, int Mana)
        {
            int mana = 100;
            if (a == true && mana >= 35)
            {
                mana = 100 - 35;
                Console.WriteLine("Вы использовали способность Omnislash");
            }
            else if (a == false && mana >= 35)
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
