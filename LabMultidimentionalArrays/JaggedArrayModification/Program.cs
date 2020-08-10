using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < jagged.Length; i++) 
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[i] = col;

            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                string[] tokens = line.Split();

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                if (row < 0 || row >=n || col < 0 || col >= n)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                else
                {
                   
                    if (command == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }

                


            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
       
        }
    }
}
