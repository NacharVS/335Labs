using System;
using System.Collections.Generic;
using System.Text;
//using static _335Labs.Girfanova.Strategy.I_Health;
//using static _335Labs.Girfanova.Strategy.I_Defence;
//using static _335Labs.Girfanova.Strategy.I_Shooting;

namespace _335Labs.Girfanova.Strategy
{
    
        public interface IName
        {
            string name { get; set; }
        }
        public interface IHealth
        {
            int hp { get; set; }
        }
        public interface IDefence
        {
            int def { get; set; }
        }
        public interface IAttack
        {
            int atk { get; set; }
        }
        public interface IMovement
        {
            int move { get; set; }
        }
    
}
