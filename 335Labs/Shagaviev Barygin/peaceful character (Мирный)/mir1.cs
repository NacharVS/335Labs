using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _335Labs.Shagaviev_Barygin.peaceful_character__Мирный_
{
    class mir1
    {
        public static void MIR()
        {
            Archer myChar = new Archer();
            Bow dragonBow = new Bow();
            var canUse = myChar.heroClass == dragonBow.heroClass;
            Console.WriteLine(canUse);
        }
        public enum HeroClass 
        {
            Archer,
            Mage,  
            Healer,
            Warrior
        }
        class Hero
        {
            public string Name { get; private set; }
        }
        class Archer : Hero
        {
            public int CritChance { get; private set; }
            public int RangeDamage { get; private set; }
            public HeroClass heroClass { get; private set; }
            public Archer()
            {
                heroClass = HeroClass.Archer;
            }
        }
        class Bow
        {
            public int CritChance { get; private set; }
            public int RangeDamage { get; private set; }
            public HeroClass heroClass { get; private set; }
            public Bow()
            {
                heroClass = HeroClass.Archer;
            }
        }
        
        
        
        

    }
}
