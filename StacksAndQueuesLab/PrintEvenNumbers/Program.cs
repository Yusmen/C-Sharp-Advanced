using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main()
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(line);
            List<int> result = new List<int>();
     
            while (numbers.Count > 0) 
            {
                int number = numbers.Dequeue();
                if (number % 2 == 0)
                {
                    
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(", ", result));
            
        }
    }
}
