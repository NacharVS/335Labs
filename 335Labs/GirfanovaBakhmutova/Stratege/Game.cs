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

        class PlaneSpeed : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение со скоростью");
            }
        }

        public abstract class Capabilities : IStrategy
        {
            Planes plane = new Planes(1, "Boeing-777", new PlaneSpeed());
            Planes.Move();
        Planes.Movable = new Boeing();
            Planes.Move();
 
        Console.ReadLine(); 
    }
        interface IMovable
        {
            void Move();
        }

       

        class Boeing : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Тип самолета");
            }
        }
        class Plane1
        {
            protected int passengers; // кол-во мест
            protected int model;
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
//ru.wikipedia.org/wiki/Boeing_737

//www.cyberforum.ru/delphi-beginners/thread1474458.html
//bool.dev/blog/detail/pattern-strategiya-strategy !!!!!!!!!!!!!!!!!
//c-sharp.pro/?p=886 разбор

//https://metanit.com/sharp/tutorial/2.15.php