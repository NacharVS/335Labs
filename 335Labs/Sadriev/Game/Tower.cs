using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev.Game
{
    class Tower : Heroes, IDefeatHero
    {
        public Tower(int power,
           int vision,
           int health
           ) : base(power, vision, health)
        {

        }
        public void DefeatHero(Heroes heroes) //Уничтожить героя оппонента
        {
            if (dead == false)
            {
                if (heroes.dead == false)
                {
                    if (heroes is Tower) //если противник - это башня оппонента, то начинается су-е-фа
                    {
                        Random rnd = new Random();
                        string[] RockPaperScissors = { "Камень", "Ножницы", "Бумага" };

                        while (dead == false | heroes.dead == false)
                        {
                            int myTIndex = rnd.Next(RockPaperScissors.Length);
                            int yourTIndex = rnd.Next(RockPaperScissors.Length);
                            Console.WriteLine($"Вы ставите {RockPaperScissors[myTIndex]}");
                            Console.WriteLine($"Оппонент ставит {RockPaperScissors[yourTIndex]}");
                            if (RockPaperScissors[myTIndex] == "Камень" & RockPaperScissors[yourTIndex] == "Ножницы")
                            {
                                heroes.dead = true;
                                Console.WriteLine("Башня оппонента пала, он позорно проиграл\n");
                                Console.WriteLine("F\n");
                                return;
                            }
                            else if (RockPaperScissors[myTIndex] == "Камень" & RockPaperScissors[yourTIndex] == "Бумага")
                            {
                                dead = true;
                                Console.WriteLine("Ваша башня пала, вы позорно проиграли\n");
                                Console.WriteLine("F\n");
                                return;
                            }
                            else if (RockPaperScissors[myTIndex] == "Ножницы" & RockPaperScissors[yourTIndex] == "Бумага")
                            {
                                heroes.dead = true;
                                Console.WriteLine("Башня оппонента пала, он позорно проиграл\n");
                                Console.WriteLine("F\n");
                                return;
                            }
                            else if (RockPaperScissors[myTIndex] == "Ножницы" & RockPaperScissors[yourTIndex] == "Камень")
                            {
                                dead = true;
                                Console.WriteLine("Ваша башня пала, вы позорно проиграли\n");
                                Console.WriteLine("F\n");
                                return;
                            }
                            else if (RockPaperScissors[myTIndex] == "Бумага" & RockPaperScissors[yourTIndex] == "Камень")
                            {
                                heroes.dead = true;
                                Console.WriteLine("Башня оппонента пала, он позорно проиграл\n");
                                Console.WriteLine("F\n");
                                return;
                            }
                            else if (RockPaperScissors[myTIndex] == "Бумага" & RockPaperScissors[yourTIndex] == "Ножницы")
                            {
                                dead = true;
                                Console.WriteLine("Ваша башня паал, вы позорно проиграли\n");
                                Console.WriteLine("F\n");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Ничья, переигровка\n");
                            }
                        }
                    }
                    else //иначе он уничтожает любого героя оппонента
                    {
                        heroes.dead = true;
                        Console.WriteLine($"Переиграл и уничтожил {heroes.GetType()} в любом случае\n");
                    }
                }
                else
                {
                    Console.WriteLine("Герой оппонента уже мертв\n");
                }
            }
            else
            {
                Console.WriteLine("Ваша башня уже уничтожена\n");
            }
        }
    }
}
