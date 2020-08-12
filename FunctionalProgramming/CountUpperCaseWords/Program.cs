using System;
using System.Linq;

namespace CountUpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                 .Split()
                 .Where(w => char.IsUpper(w[0]))
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
