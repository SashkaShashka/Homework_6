﻿using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            try
            {
                int pos = 0;
                while (true)
                {
                    Console.Write("Введите значение: ");
                    string value = Console.ReadLine().Trim().ToLower();
                    if (!values.ContainsKey(value))
                        values.Add(value, pos++);
                    else
                        throw new AlreadyExistsException(value, values[value]);
                }
            }
            catch (AlreadyExistsException e)
            {
                Console.WriteLine("Введенное значение: \"{0}\" дубрируется на {1} позиции", e.Value, e.Position);
            }
            catch (Exception e) //может быть что-то еще бросит исключение
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
