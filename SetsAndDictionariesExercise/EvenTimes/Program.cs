using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if(!dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]] = 0;
                }
                dict[numbers[i]]++;

            }

            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);

                }

            }


        }
    }
}
