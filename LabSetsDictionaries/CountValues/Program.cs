using System;
using System.Linq;
using System.Collections.Generic;

namespace CountValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> countNumbers = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (countNumbers.ContainsKey(numbers[i]))
                {
                    countNumbers[numbers[i]]++;
                }
                else
                {
                    countNumbers[numbers[i]] = 1;
                }

            }

            foreach (var num in countNumbers)
            {
                Console.WriteLine($"{num.Key } - {num.Value} times");
            }
        }
    }
}
