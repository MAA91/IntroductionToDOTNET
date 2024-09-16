using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = Console.ReadLine();
            String[] items = expression.Split('+', '-', '*', '/');
            try
            {
                double a = Convert.ToDouble(items[0]);
                double b = Convert.ToDouble(items[1]);
                if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
                else if (expression.Contains('/')) Console.WriteLine($"{a} - {b} = {a - b}");
                else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
                else if (expression.Contains('-')) Console.WriteLine($"{a} / {b} = {a / b}");
                else Console.WriteLine("No operation");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
