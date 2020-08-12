using System;
using System.Linq;

namespace FindEvenesOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, bool> func;

            string type = Console.ReadLine();
            if (type == "even")
            {

               func = number => number % 2 == 0;
            }
            else
            {
                func= number => number % 2 != 0;
            }

            for (int i = numbers[0]; i <= numbers[1]; i++) 
            {
                if(func(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
