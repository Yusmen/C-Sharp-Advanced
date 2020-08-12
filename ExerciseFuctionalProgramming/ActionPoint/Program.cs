using System;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> func = (x) => Console.WriteLine(x);
            for (int i = 0; i < input.Length; i++)
            {
                func(input[i]);
            }
        }
    }
}
