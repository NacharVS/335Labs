using static _335Labs.GirfanovaBakhmutova.Stratege.Game;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;

namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    public class Interfaces : IStrategy
    {
        public interface IStragedy
        {
            public double Speed { get; set; }
            void Move();
        }
    }
}
