using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] colEl = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colEl[col];
                }

            }
          
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] tokens = line.Split();

                int row1 = int.Parse(tokens[1]);
                int col1 = int.Parse(tokens[2]);
                int row2 = int.Parse(tokens[3]);
                int col2 = int.Parse(tokens[4]);


                if (row1 < 0
                    || row1 >= rows
                    || col1 < 0
                    || col1 >= cols
                    || row2 < 0
                    || row2 >=rows
                    || col2 < 0
                    || col2 >= cols)
                {
                   

                    Console.WriteLine("Invalid input!");

                }
                else
                {
                    string x = string.Empty;
                    x = matrix[row1, col1];
                    matrix[row1, col1]= matrix[row2, col2];
                    matrix[row2, col2]= x;
                   
                    for (int row = 0; row < rows; row++)
                    {

                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");

                        }
                        Console.WriteLine();

                    }


                }





            }
        }

        
    }
}
