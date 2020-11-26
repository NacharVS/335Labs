//using static _335Labs.Girfanova.StringMetodsGirf;
//using static _335Labs.Girfanova.MathMetodsGirf;
//using static _335Labs.GirfanovaBakhmutova.General;

using static _335Labs.GirfanovaBakhmutova.Stratege.Interfaces;
using static _335Labs.GirfanovaBakhmutova.Stratege.Character;
using static _335Labs.GirfanovaBakhmutova.Stratege.Plane;
using static _335Labs.GirfanovaBakhmutova.Stratege.Game;
using System;
using _335Labs.GirfanovaBakhmutova.Stratege;

namespace _335Labs.GirfanovaBakhmutova
{
    static class Program
    {
       static void Main(string[] args)
        {
            Plane plane = new Plane("Boeing-777", new PlaneSpeed());
            Plane.Move();
            Plane.Movable = new Boeing();
            Plane.Move();
            Console.ReadLine();
        }
    }
}





