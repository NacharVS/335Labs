using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game
{
    class Gush
    {
         public void FirstAbil (bool a, int Mana)
        {
            int mana = 100;
            if (a == true && mana >= 15)
	            {
                Console.WriteLine("Вы использовали способность Gush");
	            }
            else if (a == false && mana >= 15)
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
