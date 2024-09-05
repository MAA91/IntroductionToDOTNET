using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //фигуры
            #region
            Console.Write("Введите размер фигур: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //Квадрат
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник1
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    if (i >= j)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник2
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    if (i + j < size)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник3
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    if (i <= j)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник4
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    if (i + j >= size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ромб из звёздочек
            for (int i = -size; i <= size; i++)
            {
                for (int j = -size; j <= size; j++)
                    if ((-Math.Abs(j) + size == i) || (Math.Abs(j) - size == i))
                        Console.Write('*');
                    else
                        Console.Write(' ');
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ромб из палочек
            #region
            for (int i = 0; i < size + 1; i++)
            {
                for (int j = -size; j < size + 1; j++)
                {
                    if (Math.Abs(j) == i)
                    {
                        if (j < 0)
                            Console.Write('/');
                        else if (j > 0)
                            Console.Write(" \\");
                        else
                            Console.Write("/\\");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < size + 1; i++)
            {
                for (int j = -size; j < size + 1; j++)
                {
                    if (-Math.Abs(j) + size == i)
                    {
                        if (j < 0)
                            Console.Write('\\');
                        else if (j > 0)
                            Console.Write(" /");
                        else
                            Console.Write("\\/");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();

            //квадрат+-
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    if ((i + j) % 2 == 0)
                        Console.Write("+ ");
                    else
                        Console.Write("- ");
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();

            //шахматы
            #region
            Console.Write("Введите размер доски: ");
            int size_d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size_d; i++)
            {
                for (int j = 0; j < size_d; j++)
                    if ((i + j) % 2 == 0)
                        Console.Write("██");
                    else
                        Console.Write("  ");
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();

            //шахматы_hard
            #region
            for (int i = 0; i < size_d; i++)
                for (int j = 0; j < size_d; j++)
                {
                    for (int k = 0; k < size_d; k++)
                        for (int l = 0; l < size_d; l++)
                            if ((i + k) % 2 == 0)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                    Console.WriteLine();
                }
            #endregion
            Console.WriteLine();
        }
    }
}
