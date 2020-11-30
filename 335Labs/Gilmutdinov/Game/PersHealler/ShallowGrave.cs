using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersHealler
{
    class ShallowGrave
    {
        public void SecondAbil(int a)
        {

            int mana = 200;

            if (mana >= 100)
            {
                mana = 200 - 100;
                Console.WriteLine("Вы использовали способность Fireblast, потратили 100 маны");
            }
            else
            {
                Console.WriteLine("Не хватает маны");
            }
        }
    }
}
