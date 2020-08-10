using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(line);

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                
                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split();

                string command = tokens[0].ToLower();
               

                if (command == "add")
                {
                    int firtsNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);
                    numbers.Push(firtsNumber);
                    numbers.Push(secondNumber);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(tokens[1]);

                    if (numbers.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

 

            }
            int sum = 0;
            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        
            
        }
    }
}
