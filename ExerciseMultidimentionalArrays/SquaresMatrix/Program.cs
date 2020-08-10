using System;
using System.Linq;

namespace SquaresMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
         

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colEl = Console.ReadLine().Split();
         

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colEl[col];

                }
            }
            /*for (int row = 0; row < matrix.GetLength(0); row++)
            {
                

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }

                Console.WriteLine();
            }*/
           
            int br = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++) 
            {


                for (int col = 0; col < matrix.GetLength(1) - 1; col++)  
                {

                    if (matrix[row, col] == matrix[row + 1, col]
                        && matrix[row + 1, col] == matrix[row, col + 1]
                        && matrix[row, col + 1] == matrix[row + 1, col + 1]) 
                    {
                        br++;
                    }
                    

                }

            }

            Console.WriteLine(br);


        }
    }
}
