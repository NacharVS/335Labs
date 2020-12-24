using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersAttacker
{
    class Blade_Fury
    {
        public void FirstAbil(int a, int Mana)
        {
            int mana = 100;

            if (a == 1 & mana >= 30 )
            {
                mana = 100 - 30;
                Console.WriteLine("Вы использовали способность Blade_Fury");
            }
            if (a == 0 & mana >= 30)
            {
                Console.WriteLine("Вы не использовали способность Blade_Fury");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
