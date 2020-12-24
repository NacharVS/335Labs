using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game
{
    class Gush
    {
         public void FirstAbil (int a, int Mana)
        {
            int mana = 100;
            if (a == 1 & mana >= 15)
	            {
                Console.WriteLine("Вы использовали способность Gush");
	            }
            if (a == 0 & mana >= 15)
            {
                Console.WriteLine("Вы не использовали способность Gush");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
