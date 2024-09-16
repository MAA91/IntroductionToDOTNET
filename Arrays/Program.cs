//#define ARRAY_1
//#define ARRAY_2
#define JAGGED_ARRAY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAY_1
            Random rnd = new Random(0);
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(50, 100);
            }
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + "\t");
            Console.WriteLine($"\nСумма элементов массива: {A.Sum()}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {A.Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {A.Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {A.Max()}");
#endif

#if ARRAY_2
            int[,] A_2 =
            {
                {3, 5, 8, 13},
                {21, 34, 55, 89},
                {144, 233, 377, 610}
            };
            Console.WriteLine($"\nСумма элементов массива: {A_2.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {A_2.Cast<int>().Average()}");
            Console.WriteLine($"Минимальное значение в массиве: {A_2.Cast<int>().Min()}");
            Console.WriteLine($"Максимальное значение в массиве: {A_2.Cast<int>().Max()}");
#endif

#if JAGGED_ARRAY
            int[][] j_A =
            {
                new int[] { 0, 1, 1, 2 },
                new int[] { 3, 5, 8, 13 },
                new int[] {34, 55, 89 },
                new int[] {144, 233, 377, 610, 987 }
            };
            int sum = 0, count = 0;
            int max, min;
            max = min = j_A[0][0];
            for(int i = 0; i < j_A.Length; i++)
            {
                for(int j = 0; j < j_A[i].Length; j++) 
                {
                    count++;
                    sum += j_A[i][j];
                    if(j_A[i][j] > max)max = j_A[i][j];
                    if(min < j_A[i][j])min = j_A[i][j];
                    Console.Write($"{j_A[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"\nСумма элементов массива: {sum}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {(double)sum/count}");
            Console.WriteLine($"Минимальное значение в массиве: {min}");
            Console.WriteLine($"Максимальное значение в массиве: {max}");

#endif
        }
    }
}
