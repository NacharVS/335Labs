using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    class Game
    {
        public interface IStrategy
        {
            public double speed 
            {
                
                get => _speed;
                set => _speed = value;
            }
                void Move(double speed)
                {
                     Console.WriteLine($"Plane moving with {_speed} km/h");
                }
        }

    }

    public abstract class Capabilities
    {

    }
}
