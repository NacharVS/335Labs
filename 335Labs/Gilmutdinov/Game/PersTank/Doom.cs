using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersTank
{
    class Doom
    {
        public void SecondAbil(bool a, int Mana)
        {
            int mana = 100;

            if (a == true && mana >= 50)
            {
                Console.WriteLine("Вы использовали способность Doom");
            }
            else if (a == false && mana >= 50)
            {
                Console.WriteLine("Вы не использовали способность Doom");
            }
            else 
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
