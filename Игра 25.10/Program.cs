using System;

namespace Игра_25._10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберете кол-во попыток");
            Console.WriteLine("1 - 10 попыток");
            Console.WriteLine("2 - 3 попытки");
            Console.WriteLine("3 - 1 попытка");

            Random rand = new ();
            int num = rand.Next(0,11);

            ConsoleKey consolekey = Console.ReadKey().Key;
            switch (consolekey)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Console.WriteLine("\nПрограмма сгенерировала число от 1 до 10, угодайте его");
                    for (int i = 0; i < 10; i++)
                    {
                        int.TryParse(Console.ReadLine(), out int a);
                     
                        if (a == num)
                        {
                            Console.WriteLine("\nВы угадали !");
                            return;
                        }
                        else if (a > num)
                        {
                            Console.WriteLine("\nМного!");
                        }
                        if (a < num)
                        {
                            Console.WriteLine("\nМало!");
                        }                
                    }
                    Console.WriteLine("Вы не угодали !");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    Console.WriteLine("\nПрограмма сгенерировала число от 1 до 10, угодайте его");
                    for (int i = 0; i < 3; i++)
                    {
                        int.TryParse(Console.ReadLine(), out int a);

                        if (a == num)
                        {
                            Console.WriteLine("\nВы угадали !");
                            return;
                        }
                        else if (a > num)
                        {
                            Console.WriteLine("\nМного!");
                        }
                        if (a < num)
                        {
                            Console.WriteLine("\nМало!");
                        }
                    }
                    Console.WriteLine("Вы не угодали !");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    Console.WriteLine("\nПрограмма сгенерировала число от 1 до 10, угодайте его");
                    for (int i = 0; i < 1; i++)
                    {
                        int.TryParse(Console.ReadLine(), out int a);

                        if (a == num)
                        {
                            Console.WriteLine("\nВы угадали !");
                            return;

                        }
                        else if (a > num)
                        {
                            Console.WriteLine("\nМного!");
                        }
                        if (a < num)
                        {
                            Console.WriteLine("\nМало!");
                        }
                    }
                    Console.WriteLine("Вы не угодали !");
                    break;

                default:
                    Console.WriteLine("\nЧто-то пошло не так!");
                    Console.WriteLine("\nВыберете кол-во попыток !");
                    break;
            }

        }
    }
}
