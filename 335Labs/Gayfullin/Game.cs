using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Gayfullin
{
    internal interface IMovable

    {
        public double speed { get; }
        void Move(double speed);
        void Move();
    }
    internal interface IMovable1

    {
        public double speed { get; set; }
        public double damage { get; set; }
        public double armor { get; set; }
        void Move(double speed);
        void Move();
    }

    internal class Fermer : IMovable

    {
        public double speed => throw new NotImplementedException();

        static void Main(string[] args)
        {
            IMovable movableObject;

            movableObject = new Fermer();
            movableObject.speed = 10;
            movableObject.Move();
            
            movableObject = new Fermer();
            movableObject.speed = 10;
            movableObject.Move();
            
            movableObject = new Fermer();
            movableObject.speed = 10;
            movableObject.Move();
            
            movableObject = new Fermer();
            movableObject.speed = 10;
            movableObject.Move();

            movableObject = new Fermer();
            movableObject.speed = 10;
            movableObject.Move();


        }

        internal class Ohranick: IMovable1
            static void Main(string[] args)
        {
            IMovable1 movable1Object;

        movable1Object = new Ohranick();
        movable1Object.speed = 10;
            movable1Object.damage = 20;
            movable1Object.armor = 10;
            movable1Object.Move();
            
            movable1Object = new Ohranick();
        movable1Object.speed = 10;
            movable1Object.damage = 20;
            movable1Object.armor = 10;
            movable1Object.Move();
            
            movable1Object = new Ohranick();
        movable1Object.speed = 10;
            movable1Object.damage = 20;
            movable1Object.armor = 10;
            movable1Object.Move();
            
            movable1Object = new Ohranick();
        movable1Object.speed = 10;
            movable1Object.damage = 20;
            movable1Object.armor = 10;
            movable1Object.Move();

            movable1Object = new Ohranick();
        movable1Object.speed = 10;
            movable1Object.damage = 20;
            movable1Object.armor = 10;
            movable1Object.Move();


        }

        public void Move(double speed)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
    
   
}
