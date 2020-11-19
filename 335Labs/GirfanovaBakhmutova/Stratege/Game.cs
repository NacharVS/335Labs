using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    class Game
    {
        public interface IStrategy
        {
            public double speed { get; set; }
                void Move(double speed);
        }
    }

    public abstract class Capabilities
    {

    }
}
