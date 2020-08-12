using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string> func = str => Console.WriteLine($"Sir {str}");

            for (int i = 0; i < input.Length; i++)
            {
                func(input[i]);
            }
        }
    }
}
