using System;
using System.Collections.Generic;

namespace Hotpotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);
            while (queue.Count != 1)
            {
                for (int i = 1; i <number; i++)
                {
                    queue.Enqueue(queue.Dequeue());

                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
                
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
            
        }
    }
}
