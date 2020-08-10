using System;
using System.Linq;

namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] colEl = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colEl[col];

                }

            }
            int maxSum = int.MinValue;
            int[,] resultMatrix = new int[2,2];
                     

            for (int row = 0; row < rows - 1; row++) 
            {
                for (int col = 0; col < cols - 1; col++) 
                {
                    var currentSum = matrix[row, col]
                        + matrix[row + 1, col]
                       + matrix[row, col + 1]
                       + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        resultMatrix[0,0]=matrix[row,col];
                        resultMatrix[1, 0] = matrix[row + 1, col];
                        resultMatrix[0, 1] = matrix[row, col+1]; 
                        resultMatrix[1, 1] = matrix[row+1, col+1]; 

                    }

                }
               

            }
            for (int row = 0; row <resultMatrix.GetLength(0); row++)
            {

                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
          
        }
    }
}
