using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<List<int>, int> func = l => l.Min();

            Console.WriteLine(func(list)); 
        }
    }
}
