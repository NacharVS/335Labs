using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova
{
    sealed class plane
    {
        private double _energy;

        public double Energy
        {
            get => _energy;
            set => _energy = value;
        }
        public void Move()
        {
            Console.WriteLine($"Player moving with {_energy} hp");
        }
    }

}
