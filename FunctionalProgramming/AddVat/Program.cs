using System;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToArray();

            foreach(var price in prices)
            {

                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
