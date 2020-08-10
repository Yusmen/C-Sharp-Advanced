using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {

            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Revision")
                {
                    break;
                }

                string[] tokens = line.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();

                }
             
                 shops[shop][product] = price;


            }

            foreach (var kvp in shops)
            {

                var shop = kvp.Key;
                var products = kvp.Value;
                Console.WriteLine($"{shop}->");
                foreach (var pr in products)
                {
                    Console.WriteLine($"Product: {pr.Key}, Price: {pr.Value}");
                }

            }



        }
    }
}
