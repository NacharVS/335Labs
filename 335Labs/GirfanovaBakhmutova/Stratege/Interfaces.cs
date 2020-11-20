using System;
using System.Collections.Generic;
using System.Text;
using static _335Labs.GirfanovaBakhmutova.Stratege.Game;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;
using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;


namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    public class Interfaces : IStrategy
    {
        interface IStragedy
        {
            public double Speed { get; set; }
            void Move();
        }
    }
}
