using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftunoParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> list = new HashSet<string>();
            
   
            while (true)
            {
                string name = Console.ReadLine();

                if (name == "PARTY")
                {
                    break;
                }
                list.Add(name);
            }
            
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                if (list.Contains(line))
                {
                    if (list.Count > 0)
                    {
                        list.Remove(line);
                    }

                }
                        
            }
            Console.WriteLine(list.Count);

            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
