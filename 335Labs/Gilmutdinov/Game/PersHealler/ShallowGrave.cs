using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersHealler
{
    class ShallowGrave
    {
        public void SecondAbil(bool a, int Mana)
        {

            int mana = 200;

            if (a == true && mana >= 100)
            {
                mana = 200 - 100;
                Console.WriteLine("Вы использовали способность ShallowGrave, потратили 100 маны");
            }
            else if (a == false && mana >= 100)
            {
                Console.WriteLine("Вы не использовали способность ShallowGrave");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
