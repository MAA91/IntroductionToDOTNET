using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.BufferWidth = 120;
            Console.BufferHeight = 60;
            Console.CursorLeft = rand.Next(Console.BufferWidth);
            Console.CursorTop = rand.Next(Console.BufferHeight);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                try
                {
                    if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                        Console.CursorLeft--;
                    else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                        Console.CursorLeft++;
                    else if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                        Console.CursorTop--;
                    else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                        Console.CursorTop++;
                }
                catch
                {
                    continue;
                }
            }
            while (key != ConsoleKey.Escape);
        }
    }
}
