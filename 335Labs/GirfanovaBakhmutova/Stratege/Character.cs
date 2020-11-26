using System;
using static _335Labs.GirfanovaBakhmutova.Stratege.Game;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;

namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    public class Character : IStrategy
    {
        public double _speed;
        public double Speed
        {
            get => _speed;
            set => _speed = value;
        }
        public void Move(double speed)
        {
            throw new NotImplementedException();
        }
    }
}
