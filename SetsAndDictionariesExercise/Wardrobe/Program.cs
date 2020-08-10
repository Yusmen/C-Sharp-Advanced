using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {

                string[] elements = { " -> ", "," };
                string[] input = Console.ReadLine()
                    .Split(elements, StringSplitOptions.RemoveEmptyEntries);

                string colour = input[0];
                for (int j = 1; j < input.Length; j++)
                {
                    string vest = input[j];

                    if (!wardrobe.ContainsKey(colour))
                    {

                        wardrobe[colour] = new Dictionary<string, int>();
                    }
                    if (!wardrobe[colour].ContainsKey(vest))
                    {
                        wardrobe[colour][vest] = 0;
                    }
                    wardrobe[colour][vest]++;

                }

            }

            string[] search = Console.ReadLine().Split();

            string searchColour = search[0];
            string searchVest = search[1];

            foreach (var kvp in wardrobe)
            {

                var colour = kvp.Key;
                var clothes = kvp.Value;
                Console.WriteLine($"{colour} clothes:");
                if (searchColour == colour)
                {
                    foreach (var KVP in clothes)
                    {
                        if(KVP.Key==searchVest)
                        {

                            Console.WriteLine($"* {KVP.Key} - {KVP.Value} (found!)");

                        }
                        else
                        {
                            Console.WriteLine($"* {KVP.Key} - {KVP.Value}");
                        }

                        
                    }
                }
                else
                {
                    foreach (var KVP in clothes)
                    {

                        Console.WriteLine($"* {KVP.Key} - {KVP.Value}");


                    }

                }






            }
           
        }
    }
}
