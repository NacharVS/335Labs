using System;
using System.Collections.Generic;
using System.Text;
using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;
using static _335Labs.GirfanovaBakhmutova.Stratege.Game;

namespace _335Labs.GirfanovaBakhmutova.Stratege
{
    public class Game
    {
        public interface IStrategy
        {
            public void Capibilities() { }
        }
        public double Speed
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public void Move(double speed)
        {
            throw new NotImplementedException();
        }

        public abstract class Capabilities : IStrategy
        {
            Planes plane = new Planes(4, "Volvo", new PetrolMove());
            Plane1.Move();
        Plane.Movable = new ElectricMove();
            Plane.Move();
 
      //  Console.ReadLine(); //https://metanit.com/sharp/tutorial/2.15.php
    }
        interface IMovable
        {
            void Move();
        }

        class PetrolMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на бензине");
            }
        }

        class ElectricMove : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение на электричестве");
            }
        }
        class Plane1
        {
            protected int passengers; // кол-во пассажиров
            protected string model; // модель самолета

            public Plane1(int num, string model, IMovable mov)
            {
                this.passengers = num;
                this.model = model;
                Movable = mov;
            }
            public IMovable Movable { private get; set; }
            public void Move()
            {
                Movable.Move();
            }
        }
    }
}

//www.aviakassa.com/airplanes
//bool.dev/blog/detail/pattern-strategiya-strategy
//refactoring.guru/ru/design-patterns/template-method/csharp/example
//refactoring.guru/ru/design-patterns/strategy/csharp/example
//metanit.com/sharp/patterns/3.1.php