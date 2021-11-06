using System;

namespace Task_3
{
    class Program
    {
        static void WriteVolume(uint currentVolume, uint maxVolume)
        {
            Console.WriteLine("Заполнено {0} л. из {1} л.",currentVolume,maxVolume);
            WaitClick();
        }
        static void WaitClick()
        {
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey(true);
        }
        static void Main(string[] args)
        {
            Tank.Action = WriteVolume;
            Console.WriteLine("Введите объем цистерны");
            Tank tank = new Tank(ReadLiters());
            PrintMenu();
            ConsoleKey consoleKey;
            while (true)
            {
                try
                {
                    
                    PrintMenu();
                    consoleKey = Console.ReadKey(true).Key;
                    switch (consoleKey)
                    {
                        case ConsoleKey.A:
                            tank.Add(ReadLiters());
                            break;
                        case ConsoleKey.T:
                            tank.Take(ReadLiters());
                            break;
                        case ConsoleKey.Q:
                            return;
                    }
                }
                catch (TankOverflowException e)
                {

                    Console.WriteLine(e.Message);
                    WaitClick();
                }
                catch (NotEnoughException e)
                {

                    Console.WriteLine(e.Message);
                    WaitClick();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    WaitClick();
                }
            }
        }
        static void PrintMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(" ");
            }
            Console.CursorLeft = 0;
            Console.WriteLine("Долить A    Слить T    Выход Q");
            Console.ResetColor();
        }
        static uint ReadLiters()
        {
            uint liters;
            Console.Write("Введите литры: ");
            while (!uint.TryParse(Console.ReadLine(), out liters))
            {
                Console.WriteLine("Вы ввели что-то не то. Это не является неотрицательным числом");
                Console.Write("Введите литры: ");
            }
            return liters;
        }
    }

}
