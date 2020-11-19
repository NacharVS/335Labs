using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev.Game
{
    //Общие данные
    abstract class Own
    {
        private double _hp;
        private double _armor;
        
        public double HP
        {
            get
            {
                return _hp;
            }
            private set
            {
                _hp = value;
            }
        }
        public double Armor
        {
            get
            {
                return _armor;
            }
            private set
            {
                _armor = value;
            }
        }
    }
}
