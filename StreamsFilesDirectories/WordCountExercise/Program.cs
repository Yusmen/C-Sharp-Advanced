using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordCountExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            var tokens = File.ReadAllLines("words.txt");
            string firstWord = tokens[0];
            string secondWord = tokens[1];
            string thirdWord = tokens[2];
      

            
            using (var reader = new StreamReader("text.txt"))
            {

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    char[] symbols = { '-', ',', '.', '!', '?', ' ' };
                    string[] words = line.Split(symbols, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        string word = words[i].ToLower();
                        if (word == firstWord || word == secondWord || word == thirdWord) 
                        {

                            if (!dict.ContainsKey(word)) 
                            {
                                dict[word] = 0;
                            }
                            dict[word]++; 

                        }

                    }
                }



            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            using (var writer = new StreamWriter("actualResult.txt"))
            {

                foreach (var kvp in dict)
                {
                    writer.WriteLine($"{kvp.Key}-{kvp.Value}");

                }
            }
        }
    }
}
