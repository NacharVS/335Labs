using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Girfanova.Strategy
{
    class Game
    {
        interface IHealth
        {
            public int hp { get; set; }
        }
        interface IDefence
        {
            public int def { get; set; }
        }

        interface IBow
        {
            public int bow { get; set; }
        }

        sealed class Warrior : IHealth
        {
            public int _hp;

            public int hp
            {
                get => _hp;
                set => _hp = value;
            }

            public int _def;

            public int def
            {
                get => _def;
                set => _def = value;
            }
        }


        sealed class Pacific : IHealth
        {
            public int _hp;

            public int hp
            {
                get => _hp;
                set => _hp = value;
            }

            public int _def;

            public int def
            {
                get => _def;
                set => _def = value;
            }
        }


        sealed class WarriorTower : IHealth
        {
            public int _hp;

            public int hp
            {
                get => _hp;
                set => _hp = value;
            }

            public int _def;

            public int def
            {
                get => _def;
                set => _def = value;
            }
        }


        sealed class PacificTower : IHealth
        {
            public int _hp;

            public int hp
            {
                get => _hp;
                set => _hp = value;
            }

            public int _def;

            public int def
            {
                get => _def;
                set => _def = value;
            }
        }
    }
}
