using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Zagaynova
{
      
     public interface IObch
      {string Name { get; set; }
        int Health { get; set; }
      }
    
    public interface Iformov
    { int Speed { get; set; }
        string Way  { get; set; }
    }
    public interface IforFly
    { 
      int Height { get; set; }
    }
    public interface Iforshoot
    {string Weapon  { get; set; }
    }








    
}
