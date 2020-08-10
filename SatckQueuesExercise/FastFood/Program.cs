using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var orders = new Queue<int>(numbers);

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                int order = orders.Peek();

                if (order > capacity)
                {

                        Console.Write($"Orders left: {string.Join(" ",orders)} ");
                    
                    return;
                }
               
                    capacity -= order;
                orders.Dequeue();

            }
            Console.WriteLine("Orders complete");

            
        }
    }
}
