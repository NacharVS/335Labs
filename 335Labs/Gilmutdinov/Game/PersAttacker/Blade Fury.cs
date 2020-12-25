using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersAttacker
{
    class Blade_Fury
    {
        public void FirstAbil(bool a, int Mana)
        {
            int mana = 100;

            if (a == true && mana >= 30 )
            {
                mana = 100 - 30;
                Console.WriteLine("Вы использовали способность Blade_Fury");
            }
            else if (a == false && mana >= 30)
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
