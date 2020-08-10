using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfelemnets
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

          

            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = sizes[0];
            int m = sizes[1];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
              
                

            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);

            }
            List<int> list = new List<int>(firstSet);

            for (int i = 0; i < list.Count; i++)
            {
                if (secondSet.Contains(list[i]))
                {
                    Console.Write(list[i] + " ");
                }

            }

        }
    }
}
