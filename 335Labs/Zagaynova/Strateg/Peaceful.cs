using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class Peaceful:IObch,Iformov
    {
        string _name;
        int _health;
        int _speed;
        string _way;
        string _Kind_of_activity;
        public string Name {get => _name; set => _name = value;}
        public int Health {get => _health; set => _health = 80;}
        public int Speed {get => _speed; set => _speed = 5;}
        public string Way {get => _way; set => _way = "On foot";}
        public string Kind_of_activity { get => Kind_of_activity; set => _way = value; }
        public void  Life()
        {
            if (_health >= 0)
            { Console.WriteLine($"Paceful {_name} _Kind_of_activity: {_Kind_of_activity} "); }
            else
            {
                Console.WriteLine($"life os over");
            }
        }



    }
}
