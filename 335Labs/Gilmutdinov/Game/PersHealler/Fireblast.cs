using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gilmutdinov.Game.PersHealler
{
    class Fireblast
    {
        public void ThirdAbil(bool a, int Mana)
        {
            int mana = 200;
            
                if (a == true && mana >= 20 )
                {
                    mana = 200 - 20;
                Console.WriteLine("Вы использовали способность Fireblast, потратили 20 маны");
                }
                else if (a == false && mana >= 20)
                {
                    Console.WriteLine("Вы не использовали способность Fireblast");
                }
                else
                {
                    Console.WriteLine("Не хватает маны");
                }
            
             
        }
    }
}
