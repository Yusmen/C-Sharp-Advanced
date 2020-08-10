using System;
using System.Linq;
using System.Collections.Generic;

namespace Recordnames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);

            }
         
            foreach (var num in set)
            {
                Console.WriteLine(num);
            }
        }
    }
}
