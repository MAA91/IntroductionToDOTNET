using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Factorial
            #region
            try
            {
                Console.Write("Введите число: ");
                short n = Convert.ToInt16(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Factorial of a negative number is not defined");
                else
                {
                    double n_f = 1;
                    for (short i = 1; i <= n; i++, n_f *= i) ;
                    Console.WriteLine($"{n}! = {n_f}");

                    BigInteger n_F = 1;
                    for (short i = 1; i <= n; i++, n_F *= i) ;
                    Console.WriteLine($"{n}! = {n_F}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            #endregion

            //ромб
            #region
            Console.Write("Введите размер ромба: ");
            int size = Convert.ToInt32(Console.ReadLine()); size++;
            for (int i = -size; i <= size; i++)
            {
                if (i == 0)
                    continue;
                for (int j = -size; j <= size; j++)
                {
                    if (j == 0)
                        continue;
                    if ((-Math.Abs(j) + size == i) || (Math.Abs(j) - size == i))
                    {
                        if (i * j > 0)
                            Console.Write('/');
                        else
                            Console.Write('\\');
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            //доска
            #region
            Console.Write("Введите размер доски: ");
            int size_d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size_d * size_d;i++)
            {
                for(int j = 0; j < size_d * size_d; j++)
                {
                    if (Convert.ToBoolean((~((i / size_d % 2) | (j / size_d % 2)) % 2) | (~(~(i / size_d % 2) | ~(j / size_d % 2)) % 2))) 
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion
        }
    }
}