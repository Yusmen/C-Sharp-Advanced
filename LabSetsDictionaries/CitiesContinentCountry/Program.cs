using System;
using System.Linq;
using System.Collections.Generic;

namespace CitiesContinentCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var countriesInContinents = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!countriesInContinents.ContainsKey(continent))
                {
                    countriesInContinents[continent] = new Dictionary<string, List<string>>();
                }
                if(!countriesInContinents[continent].ContainsKey(country))
                {
                    countriesInContinents[continent][country] = new List<string>();
                }
                countriesInContinents[continent][country].Add(city);


            }


            foreach (var kvp in countriesInContinents)
            {

                var continent = kvp.Key;
                var countries = kvp.Value;

                Console.WriteLine($"{continent}:");

                foreach(var num in countries)
                {
                    var cities = num.Value;
                    Console.Write($"  {num.Key} -> ");
                    Console.Write(string.Join(", ", cities));
                    Console.WriteLine();
                }
              
            }
                    
           

            

        }
    }
}
