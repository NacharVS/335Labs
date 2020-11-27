using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin.GAME
{
    class каменьножницыбумага
    {
        public static void игрушка()
        {
            string[] combs = { "Камень", "Ножницы", "Бумага" };
            Random random = new Random();
            do
            {
                var r = random.Next(3);
                Console.WriteLine("Введите свое значение");
                for (int i = 0; i < combs.Length; i++)
                {
                    Console.WriteLine("{0} {1}", i, combs[i]);
                }
                uint input;
                while (!uint.TryParse(Console.ReadLine(), out input) || input > 2)
                {
                }
                Console.WriteLine("Соперник выбрал {0}, ваш выбор {1}", combs[r], combs[input]);
                if (r == input)
                    Console.WriteLine("Расход миром!");
                else if (input == 2 && r == 0 || input < r)
                    Console.WriteLine("Поздравляю, вы гений!");
                else
                    Console.WriteLine("Вас унизили...");
                Console.WriteLine("Рискнете сыграть еще раз? Y/N");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
            Console.WriteLine("Конец битвы, для выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
