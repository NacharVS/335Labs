using System;
using static _335Labs.GirfanovaBakhmutova.Stratege.Game;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;

namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    public class Plane : IStrategy
    {
        public static Boeing Movable;
        public Plane(string v, PlaneSpeed planeSpeed){}

        public class Planes
        {
            public double _speed;
            public static Boeing Movable;
            public void Capibilities() { }
            public double Speed
            {
                get => _speed;
                set => _speed = value;
            }
            public void Move()
            {
                Console.WriteLine($"Plane moving with {_speed} km/h");
            }
        }
        internal static void Move()
        {
            throw new NotImplementedException();
        }
    }

}

//интерфейс стратегии 