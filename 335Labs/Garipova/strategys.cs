using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova
{
    class Strategys
    {
        static void Main(string[] args)
        {
            plane movableobject;
            movableobject = new plane();
            movableobject.Energy = 100;
            movableobject.Move();

        }
        public double energy
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();

        }
        public interface game
        {
            public void Potentials();


        }
        public void Move(double energy)
        {
            Console.WriteLine($"if there are obstacles ahead, turn left ");
        }
        public abstract class Potentials : Strategys
        {
            plane Planes = new plane();

        }
        interface game1
        {
            void Move();
        }
        class plane1
        {
            protected int players;
            protected string weapons; //оружие
        }
    }

}







