using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumMaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
           

            for (int i = 0; i < n; i++) 
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = line[0];
                if (command == 1)
                {
                    int number = line[1];

                    stack.Push(number);
                }
                else if (command == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                    
                }
                else if (command == 3)
                {

                    Console.WriteLine(stack.Max());
                }
                else if (command == 4)
                {
                    Console.WriteLine(stack.Min());
                }
                    
            }

            while (stack.Count > 0) 
            {
                if (stack.Count == 1)
                {

                    Console.Write($"{stack.Pop()}");
                    break;
                }
                Console.Write($"{stack.Pop()}, ");

            }

           
        }
    }
}
