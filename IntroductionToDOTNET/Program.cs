//#define OUTPUT_TO_SCRIN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCRIN
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Introduction to .NET";
            Console.WriteLine("Hello .NET");

            //Console.CursorLeft = 15;
            //Console.CursorTop = 16;
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("Вот так задаются коардинаты");
            Console.ResetColor();

            //Console.WindowHeight = 16;
            //Console.WindowWidth = 64;
            Console.SetWindowSize(64, 16);

            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10);

            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
#endif
            Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя: {first_name}\nВозраст: {age}");
        }
    }
}
