using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string,int> parser = x=>int.Parse(x);

            int[] numbers = input.Split(", ").Select(parser).ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());

        }
       public static int Parse(string input)
        {
            return int.Parse(input);
            
        }
    }
}
