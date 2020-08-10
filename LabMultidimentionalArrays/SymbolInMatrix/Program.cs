﻿using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] colEl = Console.ReadLine().ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colEl[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            
            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {

                    if(matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                    
                   
                }

            }
            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
