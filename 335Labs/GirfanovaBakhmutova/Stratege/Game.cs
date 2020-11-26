using System;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;
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
       public class PlaneSpeed : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Перемещение со скоростью");
            }
        }
        public abstract class Capabilities : IStrategy
        {

        }
       public interface IMovable
        {
            void Move();
        }
       public class Boeing : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Тип самолета");
            }
        }
       public class Plane1
        {
            public int passengers; // кол-во мест
            public string model;
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