using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev.Game
{
    
    class Game
    {
        private readonly int towerCounter;
        private readonly int attakerCounter;
        private readonly int defenderCounter;
        
        private Heroes[] heroes = new Heroes[10];
        internal Heroes[] Team { get => heroes; set => heroes = value; }

        public Game(string team, params Heroes[] heroes) //создание команды героев для игроков
        {
            if (heroes.Length <= 10)
            {
                for (int i = 0; i < heroes.Length; i++)
                {
                    if (heroes[i] is Tower)
                    {
                        towerCounter++;
                        Console.WriteLine("Башня добавлена");
                    }
                    if (heroes[i] is Attaker)
                    {
                        attakerCounter++;
                        Console.WriteLine("Атакер добавлен");
                    }
                    if (heroes[i] is Defender)
                    {
                        defenderCounter++;
                        Console.WriteLine("Защитник добавлен");
                    }
                    
                }
                Console.WriteLine($"Команда {team} сформирована:");
                Console.WriteLine("");
                if (towerCounter == 1 && attakerCounter >= 5 && defenderCounter >=0 )
                {
                    for (int i = 0; i < heroes.Length; i++)
                    {
                        Team[i] = heroes[i];
                    }
                    foreach (Heroes s in Team)
                    {
                        if (s != null)
                        {
                            Console.WriteLine(s.ToString());
                        }
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Башней больше одной или не хватает других героев\n");
                }
            }
            else
            {
                Console.WriteLine("Превысил лимит\n");
            }
        }
        public void Start(Game game, Game game1) //старт игры 
        {
            if (Draw(game, game1))
            {
                Console.WriteLine("Битвы не будет, всем спасибо");
            }
            else
            {
                Console.WriteLine("Начинается игра:\n");
            }
        }
        public static bool Draw(Game game, Game game1) //условие ничьей
        {
            int sum1 = 0;
            int sum2 = 0;
            foreach (Heroes s in game.Team)
            {
                if (s is Tower)
                {
                    sum1 = s.Health + s.Vision + s.Power;
                }
                foreach (Heroes k in game1.Team)
                {
                    if (k is Tower)
                    {
                        sum2 = k.Health + k.Vision + k.Power;
                    }
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Объявлена ничья! Обе башни одинакого круты и войны не будет");
                Console.WriteLine("Первая команда кричит:");
                
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
