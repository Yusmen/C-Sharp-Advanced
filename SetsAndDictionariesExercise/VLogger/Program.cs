using System;
using System.Linq;
using System.Collections.Generic;

namespace VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            var userFollowers = new Dictionary<string, HashSet<string>>();
            var userFollowings = new Dictionary<string, HashSet<string>>();


            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Statistics") 
                {
                    break;
                }


                string[] tokens = input.Split();

                if (tokens.Length == 4)
                {
                   
                    if(!usernames.Contains(tokens[0]))
                    {
                        usernames.Add(tokens[0]);
                        userFollowers.Add(tokens[0], new HashSet<string>());
                        userFollowings.Add(tokens[0], new HashSet<string>());

                    }
                    
                        
                }
                else
                {
                    string hefollows = tokens[0];
                    string followed = tokens[2];

                    if (usernames.Contains(hefollows)
                        && usernames.Contains(followed)
                        && hefollows != followed) 
                    {
                        userFollowers[followed].Add(hefollows);
                        userFollowings[hefollows].Add(followed);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {usernames.Count} vloggers in its logs.");

            var topUser = userFollowers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x=>userFollowings[x.Key].Count)
                .FirstOrDefault();

            Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers," +
                $" {userFollowings[topUser.Key].Count} following");

            foreach (var username in topUser.Value.OrderBy(a=>a))
            {

                Console.WriteLine($"*  {username}");
            }

           
            int count = 2;

            foreach(var kvp in userFollowers.Where(x=>x.Key !=topUser.Key)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => userFollowings[x.Key].Count))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} " +
                    $"followers, {userFollowings[kvp.Key].Count} following");
                count++;
            }

        }
    }
}
