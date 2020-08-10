using System;
using System.Linq;

namespace DiagnalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] colEl = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colEl[col];
                }
            }
            int sumPrimary = 0;
            int sumSecondary = 0;
            for (int i = 0; i < n; i++)
            {
                sumPrimary += matrix[i, i];

            }
            for (int i = 0; i < n; i++) 
            {
                sumSecondary += matrix[i, n - 1 - i];

            }
            int difference = Math.Abs(sumPrimary - sumSecondary );
            Console.WriteLine(difference);

        }
    }
}
