using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodeicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicalEl = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    chemicalEl.Add(elements[j]);
                }


            }

            Console.WriteLine(string.Join(" ", chemicalEl));
        }
    }
}
