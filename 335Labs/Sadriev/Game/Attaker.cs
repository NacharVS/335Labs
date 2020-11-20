using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Sadriev.Game
{


    class Attaker : Heroes, IDefeatHero, ITakeDamage
    {
        public Attaker(int power,int vision,int health ) : base(power, vision, health)
        {

        }
        public void DefeatHero(Heroes heroes)//Уничтожить героя оппонента
        {
            if (dead == false)
            {
                if (heroes.dead == false)
                {
                    if (heroes.Health <= Power)
                    {
                        int sum = heroes.Health -= Power;
                        if (sum <= 0)
                        {
                            heroes.dead = true;
                            Console.WriteLine("Ваш оппонент был убит\n");
                        }
                        Console.WriteLine(heroes.Health);
                    }
                    else
                    {
                        dead = true;
                        Console.WriteLine("Я настолько слаб, что мне не зачем жить\n" +
                            "Вы умерли");
                    }
                }
                else
                {
                    Console.WriteLine("Куда ты лезишь?! Герой оппонента давно мёртв");
                }
            }
            else
            {
                Console.WriteLine("Ваш герой уже мертв, он не может сражаться");
            }
        }

        public void TakeADamage(Heroes heroes) //Нанести урон герою оппонента
        {
            if (dead == false)
            {
                if (heroes.dead == false)
                {
                    if (heroes.Vision < Vision) //если осведомленность героя выше, чем у оппонента
                    {
                        if (heroes.Health > Power)
                        {
                            heroes.Health -= Power;
                            Console.WriteLine($"Урон нанесен, хп оппонента теперь {heroes.Health}\n");
                        }
                        else
                        {
                            Console.WriteLine("'Мне запрещено уничтожать героев'\n");
                        }
                    }
                    else if (heroes.Vision > Vision)//если осведомленность оппонента выше, чем у героя
                    {
                        if (Health > Power)
                        {
                            Health -= Power;
                            Console.WriteLine($"Вас переиграли и ваш герой ударил себя, его хп {Health}\n");
                        }
                        else
                        {
                            Console.WriteLine("'Мне запрещено уничтожать героев и тем более себя'\n");
                        }
                    }
                    else//если осведомленность у обоих равна
                    {
                        if (heroes.Health > Power & Health > Power)
                        {
                            heroes.Health -= Power;
                            Health -= Power;
                            Console.WriteLine($"Пострадали оба героя, их хп теперь {Health} и {heroes.Health}\n");
                        }
                        else
                        {
                            Console.WriteLine("Мы живы\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Герой оппонента уже мертв\n");
                }
            }
            else
            {
                Console.WriteLine("Ваш герой уже мертв\n");
            }
        }


    }
}

