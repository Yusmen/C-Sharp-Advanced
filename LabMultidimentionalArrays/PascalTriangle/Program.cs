using System;
using System.Linq;


namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            long[][] jagged = new long[n][];
            jagged[0] = new long[1];
            jagged[0][0] = 1;

            for (int row = 1; row < n; row++)
            {
                jagged[row] = new long[row + 1];
                jagged[row][0] = 1;
                jagged[row][jagged[row].Length - 1] = 1;

                for (int col = 1; col < jagged[row].Length - 1; col++) 
                {
                    jagged[row][col] += jagged[row - 1][col];
                    jagged[row][col] += jagged[row - 1][col - 1];
                }


            }
            foreach(var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }

          
        }
    }
}
