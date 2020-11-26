using _335Labs.Sadriev;
using System;

namespace _335Labs.Sadriev.Game
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Attaker a = new Attaker(50, 200, 200);
            Attaker b = new Attaker(50, 200, 200);
            Attaker c = new Attaker(50, 200, 200);
            Attaker d = new Attaker(50, 200, 200);
            Attaker e = new Attaker(50, 200, 200);
            Attaker f = new Attaker(50, 200, 200);
            Attaker g = new Attaker(50, 200, 200);
            Attaker n = new Attaker(50, 200, 200);
            Attaker u = new Attaker(50, 200, 200);
            Attaker y = new Attaker(50, 200, 200);
            Defender o = new Defender(100, 200, 200);

            Tower t1 = new Tower(200, 400, 1000);
            Tower t2 = new Tower(200, 400, 9000);

            Game team1 = new Game("U",a,b,c,d,e,t1);
            Game team2 = new Game("Enemy",f,g,n,y,o,u,t2);

            team1.Start(team1, team2);
            a.TakeADamage(t2);
            a.TakeADamage(t1);
            n.TakeADamage(a);
            y.TakeADamage(a);
            n.TakeADamage(a);
            o.HealTeam(a);
            t1.DefeatHero(t2);



           
           
        
    }   
    }
}
