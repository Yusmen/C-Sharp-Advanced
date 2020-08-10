using System;
using System.IO;
using System.Linq;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("words.txt");
            string[] tokens = input.Split();
            string firstWord = tokens[0];
            string secondWord = tokens[1];
            string thirdWord = tokens[2];
            int firstWordCount = 0;
            int secondWordCount = 0;
            int thirdWordCount = 0;

            using (var reader = new StreamReader("text.txt"))
            {
                while (true)
                {
                    char[] symbols = { ',','-','!','?','.',' '};
                    string inp = reader.ReadLine();
                    if (inp == null)
                    {
                        break;
                    }

                    string[] line = inp.Split(symbols,StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].ToLower() == firstWord)
                        {
                            firstWordCount++;
                        }
                        else if (line[i].ToLower() == secondWord)
                        {
                            secondWordCount++;
                        }
                        else if(line[i].ToLower()==thirdWord)
                        {
                            thirdWordCount++;
                        }
                    }
                    
                    
                }
            }
            using (var writer = new StreamWriter("Output.txt"))
            {
                writer.WriteLine($"{firstWord}-{firstWordCount}");
                writer.WriteLine($"{secondWord}-{secondWordCount}");
                writer.WriteLine($"{thirdWord}-{thirdWordCount}");


            }


            
            
            
            
            
        }
    }
}
