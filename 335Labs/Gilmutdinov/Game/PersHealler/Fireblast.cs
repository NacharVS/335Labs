using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersHealler
{
    class Fireblast
    {
        public void ThirdAbil(int a, int Mana)
        {
            int mana = 200;
            
                if (mana >= 20)
                {
                    mana = 200 - 20;
                Console.WriteLine("Вы использовали способность Fireblast, потратили 20 маны");
                }
                else
                {
                    Console.WriteLine("Не хватает маны");
                }
             
        }
    }
}
