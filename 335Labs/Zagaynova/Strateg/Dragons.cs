using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
    class Dragons : IObch, IforFly, Iforshoot, Iformov
    {
        string _name;
        int _health=100;
        int _height;
        int _dalpoleta;
        string _weapon;
        int _speed;
        string _way;
        int _kol;
        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; }
        public int Height { get => _height; set => _height = 6000; }
        public int Dalpol { get => _dalpoleta; set => _dalpoleta = 5150; }
        public string Weapon { get => _weapon; set => _weapon = "Fire"; }
        public int Speed { get => _speed; set => _speed = value; }
        public string Way { get => _way; set => _way = "wings"; }
        public int kol { get => _kol; set => _kol = value; }

        public void Attack()
        { if (_health>=0)
            {
                Console.WriteLine($"Dragons {_name} attacks  Weapon - {_weapon}");
            }   
            else
            {
                Console.WriteLine($"life os over");  
            }
        }

         public void Shoot(int kol)
        {
            
                for (int i = 0; i >= kol; i++)
                {
                    Console.WriteLine("Shoot");
                }
            
           
            
        }
	 

	}
}
