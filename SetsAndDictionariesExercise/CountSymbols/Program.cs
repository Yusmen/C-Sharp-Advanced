using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            SortedDictionary<char, int> words = new SortedDictionary<char, int>();

            for (int i = 0; i < line.Length; i++)
            {
                if (!words.ContainsKey(line[i]))
                {
                    words[line[i]] = 0;

                }
                words[line[i]]++;

            }

            foreach (var kvp in words)
            {
                var letter = kvp.Key;
                var count = kvp.Value;

                Console.WriteLine($"{letter}: {count} time/s");
            }
        }
    }
}
