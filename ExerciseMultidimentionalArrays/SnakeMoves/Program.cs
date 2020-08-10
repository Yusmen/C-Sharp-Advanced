using System;
using System.Linq;
using System.Collections.Generic;


namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            char[][] matrix = new char[rows][];

            var snake = Console.ReadLine().ToCharArray();

            var queue = new Queue<char>(snake);

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                for (int col = 0; col < cols; col++)
                {
                    char charToAdd = queue.Dequeue();
                    matrix[row][col] = charToAdd;
                    queue.Enqueue(charToAdd);

                }

            }
            foreach(var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
                
        }
    }
}
