using System;
using System.Linq;

namespace BombTheBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimemsions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimemsions[0];
            int cols = dimemsions[1];

            int[][] matrix = new int[rows][];

            int[] bombParamteters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombRow = bombParamteters[0];
            int bombCol = bombParamteters[1];
            int bombRadius = bombParamteters[2];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));

                    if (distance <= bombRadius)
                    {
                        matrix[row][col] = 1;
                    }

;               }

            }

            int[][] secondMatrix = new int[cols][];
            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];
                for (int col = 0; col < rows; col++)
                {

                    secondMatrix[row][col] = matrix[col][row];

                }
                secondMatrix[row]=secondMatrix[row].OrderByDescending(x => x).ToArray();


            }
            foreach (var row in secondMatrix)
            {
                Console.WriteLine(string.Join("", row));
            }
          /*  for (int row = 0; row < rows; row++)
            {
                
                for (int col = 0; col < cols; col++)
                {

                    matrix[row][col] = secondMatrix[col][row];

                }
                

            }
            foreach(var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }*/


        }
    }
}
